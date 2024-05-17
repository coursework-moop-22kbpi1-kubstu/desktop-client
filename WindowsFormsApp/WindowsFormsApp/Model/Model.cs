using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.ControllersHTTP;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model
{
    public class Model
    {
        ControllersHTTP.UserProviderAPI userController = new ControllersHTTP.UserProviderAPI();

        public ViewModel ViewModel;

        public Model()
        {
        }
        public void UpdateListUsers()
        {
        }
    }
}
