using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp.Model.EventAndDelegate;
using WindowsFormsApp.Model.Entities;
using WindowsFormsApp.Model.Provider;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Threading;
using System.Net;
using System.Xml.Linq;

namespace WindowsFormsApp.Model
{
    public class Model
    {
        public event EventNewNotification AddNewNotificationEvent;
        public event EventNewUser AddNewUserEvent;

        private int updateDelayTime = 250;

        private LoginProviderAPI loginUser;
        private IUserProvideAPI userProvideAPI;
        private INotificationProviderAPI notificationProviderAPI;

        private Thread threadCyclicUpdatingIncomingNotifications;

        private List<UserChatInfo> listUserChatInfo;
        private bool flagCyclicUpdatingIncomingNotifications = true;
        private int lastNotificationReceived = -1;
        private int lastPage = 0;

        public List<UserChatInfo> ListUserChatInfo
        {
            get { return listUserChatInfo; }
        }
        public int UpdateDelayTime
        {
            get { return updateDelayTime; }
            set { updateDelayTime = value < 0 ? 1 : value; }
        }

        public Model()
        {
            listUserChatInfo = new List<UserChatInfo>();
            loginUser = new LoginProviderAPI(new ProviderFactory.UserProviderAPIFactory(), new ProviderFactory.NotificationProviderPIFactory());
        }

        #region вход выход регистрация
        public async Task<HttpResponseMessage> LoginAsync(string userLogin, string userPassword)
        {
            LoginProviderAPI.ServerResponse serverResponse = await loginUser.LoginAsync(userLogin, userPassword);
            if (serverResponse.responseMessage.StatusCode == HttpStatusCode.OK)
            {
                userProvideAPI = serverResponse.iUserProvideAPI;
                notificationProviderAPI = serverResponse.iNotificationProviderAPI;
                StartCyclicUpdatingIncomingNotifications();

            }
            return serverResponse.responseMessage;
        }
        public async Task<HttpResponseMessage> Signup(string name, string login, string password)
        {
            return await loginUser.SignupAsync(name, login, password);
        }
        public async Task<HttpResponseMessage> Logout()
        {
            return await loginUser.LogoutAsync();
        }
        #endregion

        #region CyclicUpdatingIncomingNotifications
        public void StartCyclicUpdatingIncomingNotifications()
        {
            threadCyclicUpdatingIncomingNotifications = new Thread(CyclicUpdatingIncomingNotifications);
            threadCyclicUpdatingIncomingNotifications.Name = $"Поток StartCyclicUpdatingIncomingNotifications";
            threadCyclicUpdatingIncomingNotifications.Start();

            flagCyclicUpdatingIncomingNotifications = true;
        }
        public void EndCyclicUpdatingIncomingNotifications()
        {
            if (flagCyclicUpdatingIncomingNotifications)
            {
                threadCyclicUpdatingIncomingNotifications.Abort();
                threadCyclicUpdatingIncomingNotifications.Join();
                threadCyclicUpdatingIncomingNotifications = null;
                flagCyclicUpdatingIncomingNotifications = false;
            }
            Thread.Sleep(updateDelayTime << 1);
        }
        private void CyclicUpdatingIncomingNotifications()
        {
            while (flagCyclicUpdatingIncomingNotifications)
            {
                Notification[] newNotifications = (GetAllAfter(lastNotificationReceived).Result).ToArray();
                bool flagSenderFound = false;
                foreach (Notification notification in newNotifications)
                {
                    if (notification.Id > lastNotificationReceived)
                    {
                        lastNotificationReceived = notification.Id;
                    }
                    foreach (UserChatInfo userChatInfo in listUserChatInfo)
                    {
                        if (userChatInfo.User.Id == notification.UserOwner.Id)
                        {
                            userChatInfo.Add(notification);
                            flagSenderFound = true;
                            AddNewNotificationEvent.Invoke(this, new EventNewNotificationData(notification));
                            break;
                        }
                    }
                    if (!flagSenderFound)
                    {

                        MessageBox.Show(JsonConvert.SerializeObject(notification, Formatting.Indented));
                        Add(notification.UserOwner, notification);
                    }
                }
                Thread.Sleep(updateDelayTime);
            }
        }
        #endregion

        public void Add(User user)
        {
            UserChatInfo newUserChatInfo = new UserChatInfo(user, new List<Notification>());
            AddNewUserEvent.Invoke(this, new EventNewUserData(user, newUserChatInfo));
            listUserChatInfo.Add(newUserChatInfo);
        }
        public void Add(User user, Notification notification)
        {
            UserChatInfo newUserChatInfo = new UserChatInfo(user, new List<Notification>());
            AddNewUserEvent.Invoke(this, new EventNewUserData(user, newUserChatInfo));
            newUserChatInfo.Add(notification);
            listUserChatInfo.Add(newUserChatInfo);
        }

        public async Task<HttpResponseMessage> SentNotification(Notification notification, int idRecipient)
        {
            HttpResponseMessage httpResponseMessage = await notificationProviderAPI.SendNotificationAsync(notification.Title, notification.Message, idRecipient);
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                User userRecipient = await userProvideAPI.GetOfAsync(idRecipient);
                foreach (UserChatInfo userChatInfo in listUserChatInfo)
                {
                    if (userChatInfo.User == userRecipient)
                    {
                        userChatInfo.Add(notification);
                        break;
                    }
                }
                Add(userRecipient, notification);
            }
            return httpResponseMessage;
        }
        public async Task<HttpResponseMessage> SentNotification(Notification notification, int[] idRecipients)
        {
            HttpResponseMessage httpResponseMessage = await notificationProviderAPI.SendNotificationAsync(notification.Title, notification.Message, idRecipients);
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (int idRecipient in idRecipients)
                {
                    User userRecipient = await userProvideAPI.GetOfAsync(idRecipient);
                    foreach (UserChatInfo userChatInfo in listUserChatInfo)
                    {
                        if (userChatInfo.User == userRecipient)
                        {
                            userChatInfo.Add(notification);
                            break;
                        }
                    }
                    Add(userRecipient, notification);
                }
            }
            return httpResponseMessage;
        }
        public async Task<HttpResponseMessage> SentNotification(Notification notification, string role)
        {
            HttpResponseMessage httpResponseMessage = await notificationProviderAPI.SendNotificationAsync(notification.Title, notification.Message, role);
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (User user in await GetAllUser())
                {
                    if (user.Role != role) break;
                    bool flag = true;
                    foreach (UserChatInfo userChatInfo in listUserChatInfo)
                    {
                        if (userChatInfo.User.Id == user.Id)
                        {
                            userChatInfo.Add(notification);
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Add(user, notification);
                    }
                }
            }
            return httpResponseMessage;
        }
        // полученные 
        public async Task<List<Notification>> GetAllAcceptedNotification()
        {
            int size = 10;
            int page = 0;
            Notification[] notifications;
            List<Notification> allNotifications = new List<Notification>();
            do
            {
                notifications = await notificationProviderAPI.GetAllAsync(page++, size);
                foreach (Notification notification in notifications)
                {
                    allNotifications.Add(notification);
                }
            }
            while (notifications.Length != 0);
            return allNotifications;
        }
        // отправленые 
        public async Task<List<Notification>> GetAllSentNotification()
        {
            int size = 10;
            int page = 0;
            Notification[] notifications;
            List<Notification> allNotifications = new List<Notification>();
            do
            {
                notifications = await notificationProviderAPI.GetAllSentNotificationsAsync(page++, size);
                foreach (Notification notification in notifications)
                {
                    allNotifications.Add(notification);
                }
            }
            while (notifications.Length != 0);
            return allNotifications;
        }
        public async Task<List<User>> GetAllUser()
        {
            int size = 10;
            int page = 0;
            User[] users;
            List<User> allUsers = new List<User>();
            do
            {
                users = await userProvideAPI.GetAllAsync(page++, size);
                foreach (User user in users)
                {
                    allUsers.Add(user);
                }
            }
            while (users.Length != 0);
            return allUsers;
        }

        public async Task<List<User>> SearchUser(string keyWord)
        {
            int size = 10;
            int page = 0;
            User[] users;
            List<User> allUsers = new List<User>();
            do
            {
                users = await userProvideAPI.GetAllAsync(page++, size);
                foreach (User user in users)
                {
                    if (user.UserName.IndexOf(keyWord) != -1 || user.Login.IndexOf(keyWord) != -1)
                    {
                        allUsers.Add(user);
                    }
                }
            }
            while (users.Length != 0);
            return allUsers;
        }
        public async Task<List<User>> SearchUser(int identifier)
        {
            int size = 10;
            int page = 0;
            User[] users;
            List<User> allUsers = new List<User>();
            do
            {
                users = await userProvideAPI.GetAllAsync(page++, size);
                foreach (User user in users)
                {
                    if (user.Id.ToString().IndexOf(identifier.ToString()) != -1)
                    {
                        allUsers.Add(user);
                    }
                }
            }
            while (users.Length != 0);
            return allUsers;
        }

        private async Task<List<Notification>> GetAllAfter(int notificationBefore)
        {
            int size = 25;
            int page = lastPage;
            Notification[] notifications;
            List<Notification> allNotifications = new List<Notification>();
            do
            {
                notifications = await notificationProviderAPI.GetAllAsync(page++, size);
                foreach (Notification notification in notifications)
                {
                    if (notification.Id > notificationBefore)
                    {
                        allNotifications.Add(notification);
                    }
                }
            }
            while (notifications.Length != 0);
            lastPage = page - 2;
            if (lastPage < 0) lastPage = 0;
            return allNotifications;
        }
    }
}
