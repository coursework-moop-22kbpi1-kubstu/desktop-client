using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;
using WindowsFormsApp.Model.Provider;

namespace WindowsFormsApp.Model.ProviderFactory
{
    public interface IUserProviderAPIFactory : IProviderAPIFactory<User>
    {
        new IUserProvideAPI GetProviderAPI();
    }
}
