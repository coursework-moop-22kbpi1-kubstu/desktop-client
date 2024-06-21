using System;
using WindowsFormsApp.Model.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model.EventAndDelegate
{
    public delegate void EventNewNotification(object sender, EventNewNotificationData e);
    public delegate void EventNewUser(object sender, EventNewUserData e);
    public class EventNewNotificationData : EventArgs
    {
        public Notification newNotification;
        public EventNewNotificationData(Notification newNotification)
        {
            this.newNotification = newNotification;
        }
    }
    public class EventNewUserData : EventArgs
    {
        public User newUser;
        public UserChatInfo newUserChatInfo;
        public EventNewUserData(User newUser, UserChatInfo newUserChatInfo)
        {
            this.newUser = newUser;
            this.newUserChatInfo = newUserChatInfo;
        }
    }
}
