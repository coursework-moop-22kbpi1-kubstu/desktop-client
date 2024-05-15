using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model;

namespace TestHTTPClient.Model
{
    public class UserRepository
    {
        List<User> users;
        public UserRepository()
        {
            users = new List<User>();
        }
        public void Save(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == user.Id)
                {
                    users[i] = user;
                    return;
                }
            }
            users.Add(user);
        }
        public User GetId(int id)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                {
                    return users[i];
                }
            }
            return null;
        }
        public User[] GetAll(int id)
        {
            return users.ToArray();
        }
    }
}
