using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.ControllersHTTP
{
    internal class UserController : HTTPManager
    {
        string addressUsers = "http://83.147.247.105:8080/users";
        public List<User> GetAllUsers()
        {
            HttpResponseMessage httpResponseMessage = Get(addressUsers).Result;

            Console.ForegroundColor = ConsoleColor.White;
            string jsonFormatDataStr = httpResponseMessage.Content.ReadAsStringAsync().Result;
            string[] jsonFormatDataArr = jsonFormatDataStr.Split('\n');

            var resultListUser = new List<User>();

            for (int i = 0; i < jsonFormatDataArr.Length; i++)
            {
                if (jsonFormatDataArr[i].Contains("id"))
                {
                    int id = Convert.ToInt32(jsonFormatDataArr[i].Split(':')[1]);
                    string username = jsonFormatDataArr[++i].Split(':')[1];
                    string login = jsonFormatDataArr[++i].Split(':')[1];
                    string role = jsonFormatDataArr[++i].Split(':')[1];

                    User newUser = new User(id, username, login, role);
                    resultListUser.Add(newUser);
                }
            }
            for (int i = 0; i < resultListUser.Count; i++)
            {
                Console.Write("id: " + resultListUser[i].Id + "   UserName:" + resultListUser[i].UserName + "   Login:" + resultListUser[i].Login + "   Role:" + resultListUser[i].Role + "   ");
                Console.WriteLine();
            }
            return resultListUser;
        }
    }
}
