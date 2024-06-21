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
        public IUserProvideAPI GetProviderAPI()
        {
            return new UserProviderAPI();
        }

        IProviderAPI<User> IProviderAPIFactory<User>.GetProviderAPI()
        {
            return new UserProviderAPI();
        }
    }
}
