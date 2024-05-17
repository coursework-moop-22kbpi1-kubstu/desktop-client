using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.Provider
{
    public class NotificationProviderAPI : INotificationProviderAPI
    {
        public void ChangeNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public void ChangeNotification(Notification notification, int id)
        {
            throw new NotImplementedException();
        }

        public void CreateNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Notification[] GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Notification GetOf(int id)
        {
            throw new NotImplementedException();
        }
    }
}
