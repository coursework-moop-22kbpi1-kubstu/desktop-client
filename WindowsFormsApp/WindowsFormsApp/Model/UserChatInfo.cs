using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model
{
    public class UserChatInfo
    {
        public event EventAndDelegate.EventNewNotification AddNewNotificationEvent;

        private List<Notification> notifications = new List<Notification>();    // полученные
        private User user;

        public User User
        {
            get { return user; }
        }
        public List<Notification> NHotifications
        {
            get { return notifications; }
        }

        public UserChatInfo(User user, List<Notification> notifications)
        {
            this.user = user;
            this.notifications = notifications;
        }

        public void Add(Notification notification)
        {
            notifications.Add(notification);
            AddNewNotificationEvent.Invoke(this, new EventAndDelegate.EventNewNotificationData(notification));
        }
    }
}
