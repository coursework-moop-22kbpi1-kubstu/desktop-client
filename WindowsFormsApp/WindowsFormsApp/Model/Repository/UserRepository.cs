using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model;
using WindowsFormsApp.Model.Repository;

namespace TestHTTPClient.Model
{
    public class UserRepository : IRepository<User>
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
        public User Get(int id)
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
        public User[] GetAll()
        {
            return users.ToArray();
        }
        public void Delete(int id)
        {
            users.RemoveAt(id);
        }
    }
}
