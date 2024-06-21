using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;
using static WindowsFormsApp.Model.Provider.NotificationProviderAPI;

namespace WindowsFormsApp.Model.Provider
{
    public interface INotificationProviderAPI : IProviderAPI<Notification>
    {
        Task<HttpResponseMessage> SendNotificationAsync(string title, string message, int idRecipient);
        Task<HttpResponseMessage> SendNotificationAsync(string title, string message, int[] idRecipients);
        Task<HttpResponseMessage> SendNotificationAsync(string title, string message, string role);
        Task<HttpResponseMessage> SendNotificationAsync(Notification notification, int idRecipient);
        Task<HttpResponseMessage> ChangeNotificationAsync(Notification notification);
        Task<Notification[]> GetAllSentNotificationsAsync(int page, int size);
    }
}
