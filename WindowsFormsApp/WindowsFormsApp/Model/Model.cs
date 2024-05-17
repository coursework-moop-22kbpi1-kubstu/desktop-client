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
        ControllersHTTP.UserController userController = new ControllersHTTP.UserController();

        public ViewModel ViewModel;
        private User[] allUser;
        private Profile profile;

        public Model()
        {
        }
        public void UpdateListUsers()
        {
            allUser = userController.GetAllUsers().ToArray();
        }
    }
}
