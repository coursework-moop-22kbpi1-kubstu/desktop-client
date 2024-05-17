using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;
using WindowsFormsApp.Model.Provider;

namespace WindowsFormsApp.Model.ProviderFactory
{
    internal class UserProviderAPIFactory : IUserProviderAPIFactory
    {
        public IUserProvideAPI GetProviderAPI(Notification notification)
        {
            return new UserProviderAPI();
        }

        public IProviderAPI<User> GetProviderAPI(IEntity entities)
        {
            return ((IUserProviderAPIFactory)this).GetProviderAPI(entities);
        }
    }
}
