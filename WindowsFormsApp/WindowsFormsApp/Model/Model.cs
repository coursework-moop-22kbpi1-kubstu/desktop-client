using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestHTTPClient.Model.ControllersHTTP;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model
{
    public class Model
    {
        UserController userController = new UserController();

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
