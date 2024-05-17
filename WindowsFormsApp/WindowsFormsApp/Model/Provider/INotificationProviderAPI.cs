using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.Provider
{
    public interface INotificationProviderAPI : IProviderAPI<Notification>
    {
        void CreateNotification(Notification notification);
        void ChangeNotification(Notification notification);
        void ChangeNotification(Notification notification, int id);
    }
}
