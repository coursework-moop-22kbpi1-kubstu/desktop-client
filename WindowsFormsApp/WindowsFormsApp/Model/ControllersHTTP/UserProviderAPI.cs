using Newtonsoft.Json;
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
    internal class UserProviderAPI : HTTPManager
    {
        string addressUsers = "http://83.147.247.105:8080/users";
        public class ResultMessage<T>
        {
            public List<T> Content;
        }
        public List<User> GetAllUsers()
        {
            HttpResponseMessage httpResponseMessage = Get(addressUsers).Result;
            string jsonFormatDataStr = httpResponseMessage.Content.ReadAsStringAsync().Result;
            var resultListUser = JsonConvert.DeserializeObject<ResultMessage<User>>(jsonFormatDataStr).Content;
            return resultListUser;
        }
    }
}