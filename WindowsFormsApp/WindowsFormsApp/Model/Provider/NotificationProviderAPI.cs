using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model.ControllersHTTP;
using WindowsFormsApp.Model.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp.Model.Provider
{
    public class NotificationProviderAPI : INotificationProviderAPI
    {
        string address = "http://83.147.247.105:8080/notifications";

        public async Task<HttpResponseMessage> ChangeNotificationAsync(Notification notification)
        {
            return await HTTPManager.PatchAsync(address + "/" + notification.Id, JsonConvert.SerializeObject(notification));
        }

        public async Task<HttpResponseMessage> DeleteByIdAsync(int id)
        {
            return await HTTPManager.DeleteAsync(address + "/" + id);
        }
        public async void DeleteAllAsync()
        {
            Notification[] notifications;
            do
            {
                notifications = await GetAllSentNotificationsAsync(0, 10);
                foreach (Notification notification in notifications)
                {
                    _ = DeleteByIdAsync(notification.Id);
                }
            } while (notifications.Length > 0);
        }

        // Просмотр истории принятых уведомлений
        public async Task<Notification[]> GetAllAsync(int page, int size)
        {
            return JsonConvert.DeserializeObject<Notification[]>(await HTTPManager.GetAsync(address + "/history", $"page={page}&size={size}").Result.Content.ReadAsStringAsync());
        }

        // Просмотр истории отправленных уведомлений
        public async Task<Notification[]> GetAllSentNotificationsAsync(int page, int size)
        {
            HttpResponseMessage responseMessage = await HTTPManager.GetAsync(address + "/my", $"page={page}&size={size}");
            return JsonConvert.DeserializeObject<Notification[]>(responseMessage.Content.ReadAsStringAsync().Result);
        }

        public async Task<Notification> GetOfAsync(int id)
        {
            HttpResponseMessage responseMessage = await HTTPManager.GetAsync(address + "/send/" + id);
            string str = await responseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Notification[]>(str)[0];
        }

        #region SendNotificationAsync
        public async Task<HttpResponseMessage> SendNotificationAsync(string title, string message, int idRecipient)
        {
            string jsonObj = "{\"title\":\"" + title + "\",\"message\":\"" + message + "\"" + "}";
            return await HTTPManager.PostAsync(address + "/send/" + idRecipient, jsonObj);
        }
        public async Task<HttpResponseMessage> SendNotificationAsync(Notification notification, int idRecipient)
        {
            string jsonObj = "{\"title\":\"" + notification.Title + "\",\"message\":\"" + notification.Message + "\"" + "}";
            return await HTTPManager.PostAsync(address + "/send/" + idRecipient, jsonObj);
        }
        public async Task<HttpResponseMessage> SendNotificationAsync(string title, string message, int[] idRecipient)
        {
            string userIds = "\"";
            int Length = idRecipient.Length;
            for (int i = 0; i < Length - 1; i++)
            {
                userIds += idRecipient[i] + ",";
            }
            userIds += idRecipient[Length - 1] + "\"";
            string jsonObj = "{" +
                "\"userIds\": " + userIds + "," +
                "\"userRole\": null," +
                "\"notification\": {" +
                    "\"title\": \"" + title + "\"," +
                    "\"message\": \"" + message + "\"" +
                    "}" +
                "}";
            return await HTTPManager.PostAsync(address + "/dispatch", jsonObj);
        }
        public async Task<HttpResponseMessage> SendNotificationAsync(string title, string message, string role)
        {
            if (role != "ADMIN" && role != "EMPLOYEE")
            {
                role = "USER";
            }
            string jsonObj = "{" +
                "\"userIds\": null," +
                "\"userRole\": \"" + role + "\"," +
                "\"notification\": {" +
                    "\"title\": \"" + title + "\"," +
                    "\"message\": \"" + message + "\"" +
                    "}" +
                "}";
            return await HTTPManager.PostAsync(address + "/dispatch", jsonObj);
        }
        #endregion
    }
}
