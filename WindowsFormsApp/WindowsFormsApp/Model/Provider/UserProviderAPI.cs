using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.ControllersHTTP;

namespace WindowsFormsApp.Model.Provider
{
    public class UserProviderAPI : IUserProvideAPI
    {
        public class ServerResponse<T>
        {
            public class Link
            {
                public string rel;
                public string href;
            }
            public Link[] links;
            public T[] content;
        }

        string address = "http://83.147.247.105:8080/users";
        HTTPManager HTTPManager = new HTTPManager();

        public User[] GetAll(int page, int size)
        {
            try
            {
                ServerResponse<User> a = JsonConvert.DeserializeObject<ServerResponse<User>>(
                    HTTPManager.Get(
                            address, $"page={page}&size={size}"
                        ).Result.Content.ReadAsStringAsync().Result
                    );
                //if (a == null)
                //{
                //    return new User[0];
                //}
                return a.content;
            }
            catch
            {
                return new User[0];
            }
        }
        public User GetOf(int id)
        {
            try
            {
                ServerResponse<User> a = JsonConvert.DeserializeObject<ServerResponse<User>>(
                HTTPManager.Get(
                                address + "/" + id
                            ).Result.Content.ReadAsStringAsync().Result
                        );
                if (a != null && a.content.Length != 0)
                {
                    return a.content[0];
                }
                throw new Exception("Пользователь с заданным id:" + id + " не был найден");
            }
            catch
            {
                throw new Exception("Не удалось найти пользователя с id:" + id);
            }
        }
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
        public User[] UsersFromList(IEnumerable<int> listId)
        {
            throw new NotImplementedException();
        }
    }
}