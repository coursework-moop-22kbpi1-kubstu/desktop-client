using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model
{
    public class User
    {
        protected int id;
        protected string userName;
        protected string login;
        protected Role role;

        public int Id { get { return id; } }
        public string UserName { get { return userName; } }
        public string Login { get { return login; } }
        public Role Role { get { return role; } }

        public User(int id, string userName, string login, Role role)
        {
            this.id = id;
            this.userName = userName;
            this.login = login;
            this.role = role;
        }
    }
}
