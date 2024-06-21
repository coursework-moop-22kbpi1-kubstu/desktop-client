using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model.Entities;
using WindowsFormsApp.Model.Provider;
using WindowsFormsApp.Model.ProviderFactory;
using System.IO;
using System.Threading;
using System.Security;
using WindowsFormsApp.Model.EventAndDelegate;
using WindowsFormsApp.Model;
using WindowsFormsApp.View;

namespace WindowsFormsApp.ViewModel
{
    public class ViewModel
    {
        public enum MessageSendingModeEnum
        {
            none,
            oneUser,
            multipleUsers,
            byRole
        }

        public event EventNewNotification AddNewNotificationEvent;
        public event EventNewUser AddNewUserEvent;

        private const string DataFolder = "C:\\data folder";
        private const string FileFolder = DataFolder + "\\users.txt";

        public View.View view;
        public Model.Model model;

        private bool flagCyclicSearchIdNotification = true;
        private int updateDelayTime = 250;

        private string userLogin;
        private string userName;
        private string userPassword;
        private string title;
        private string message;

        private User my;

        private int selectedUserId = -1;
        private MessageSendingModeEnum messageSendingMode = MessageSendingModeEnum.none;
        private int[] selectedUsers;
        private string selectedRole;
        private List<Notification> notificationsWithoutID;
        //private List<int> viewedNotification;

        //private LoginProviderAPI loginUser = new LoginProviderAPI(new UserProviderAPIFactory(), new NotificationProviderPIFactory());

        #region свойства для пользователя
        public string UserLogin
        {
            get { return userLogin; }
            set
            {
                userLogin = value;
                view.inputEnteringUserLogin.Text = userLogin;
            }
        }
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                view.inputEnteringUserLogin.Text = userName;
            }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set
            {
                userPassword = value;
                view.inputEnteringUserPassword.Text = userPassword;
            }
        }
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                //Form.inputEnteringUserPassword.Text = userPassword;
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                //Form.inputEnteringUserPassword.Text = userPassword;
            }
        }
        #endregion

        #region прочие свойства
        public int UpdateDelayTime
        {
            get { return updateDelayTime; }
            set { updateDelayTime = value < 0 ? 1 : value; }
        }
        public MessageSendingModeEnum MessageSendingMode
        {
            get { return messageSendingMode; }
            set { messageSendingMode = value; }
        }
        #endregion

        public ViewModel()
        {
            model = new Model.Model();
            my = null;
            selectedUsers = new int[0];
            selectedRole = "USER";
            notificationsWithoutID = new List<Notification>();
            //viewedNotification = new List<int>();
        }

        #region login and registration
        public async void LoginAsync()
        {
            HttpResponseMessage httpResponseMessage = await model.LoginAsync(userLogin, userPassword);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                view.SwitchingMainForm();
                foreach (User user in await model.GetAllUser())
                {
                    if (user.Login == userLogin)
                    {
                        my = user;
                        break;
                    }
                }
            }
            else
            {
                view.ErrorMessage("Не удалось произвести вход в аккаунт StatusCode - (" + (int)httpResponseMessage.StatusCode + ") " + httpResponseMessage.StatusCode);
            }
        }
        public async void SignupAsync()
        {
            HttpResponseMessage httpResponseMessage = await model.Signup(userName, userLogin, userPassword);
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                view.SwitchingLoginForm();
            }
            else
            {
                view.ErrorMessage("Не удалось произвести регистрацию StatusCode - " + httpResponseMessage.StatusCode);
            }
        }
        public async void LogoutAsync()
        {
            HttpResponseMessage httpResponseMessage = await model.Logout();
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                view.CloseForm();
            }
            else
            {
                view.ErrorMessage("Не удалось произвести выход из аккаунта StatusCode - " + httpResponseMessage.StatusCode);
            }
        }
        #endregion

        public async void SentNotification()
        {
            if (messageSendingMode == MessageSendingModeEnum.none)
            {
                view.ErrorMessage("Не удалось произвести отправку сообщения, (messageSendingMode == MessageSendingModeEnum.none = true)");
                return;
            }

            HttpResponseMessage httpResponseMessage = null;
            Notification notification = new Notification(-1, title, message, DateTime.Now, my);
            if (messageSendingMode == MessageSendingModeEnum.oneUser)
            {
                httpResponseMessage = await model.SentNotification(notification, selectedUserId);
            }
            else if (messageSendingMode == MessageSendingModeEnum.multipleUsers)
            {
                if (selectedUsers.Length == 0) return;
                httpResponseMessage = await model.SentNotification(notification, selectedUsers);
            }
            else if (messageSendingMode == MessageSendingModeEnum.byRole)
            {
                httpResponseMessage = await model.SentNotification(notification, selectedRole);
            }

            if (httpResponseMessage == null || httpResponseMessage.StatusCode != HttpStatusCode.OK)
            {
                view.ErrorMessage("Не удалось произвести отправку сообщения, " +
                    httpResponseMessage == null ?
                        "не удалось получить ответ от сервера" :
                        ("StatusCode - " + httpResponseMessage.StatusCode)
                    );
            }
            else
            {
                notificationsWithoutID.Add(notification);
            }
        }

        #region event of adding a user or notification
        public void EventNewNotification(object sender, EventNewNotificationData e)
        {
            AddNewNotificationEvent.Invoke(sender, e);
        }
        public void EventNewUser(object sender, EventNewUserData e)
        {
            MessageBox.Show(JsonConvert.SerializeObject(sender, Formatting.Indented));
            AddNewUserEvent.Invoke(sender, e);
        }
        #endregion

        #region search by login/name or ID

        #endregion

    }
}