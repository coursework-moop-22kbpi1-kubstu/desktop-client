using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.Entities
{
    public class User : IEntity
    {
        protected int id;
        protected string userName;
        protected string login;
        protected string role;

        public int Id
        {
            get { return id; }
        }
        public string UserName
        {
            get { return userName; }
        }
        public string Login
        {
            get { return login; }
        }
        public string Role
        {
            get { return role; }
        }

        public User(int id, string userName, string login, string role)
        {
            this.id = id;
            this.userName = userName;
            this.login = login;
            this.role = role;
        }
    }
}
