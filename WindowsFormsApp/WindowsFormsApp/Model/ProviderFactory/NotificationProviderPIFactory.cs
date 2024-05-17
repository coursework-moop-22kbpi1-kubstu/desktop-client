using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;
using WindowsFormsApp.Model.Provider;

namespace WindowsFormsApp.Model.ProviderFactory
{
    public class NotificationProviderPIFactory : INotificationProviderAPIFactory
    {
        public INotificationProviderAPI GetProviderAPI(Notification notification)
        {
            return new NotificationProviderAPI();
        }

        public IProviderAPI<Notification> GetProviderAPI(IEntity entities)
        {
            return ((INotificationProviderAPIFactory)this).GetProviderAPI(entities);
        }
    }
}
