using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.ControllersHTTP;
using WindowsFormsApp.Model.Entities;

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

        const string address = "http://83.147.247.105:8080/users";
        //HTTPManager HTTPManager = new HTTPManager();

        public async Task<HttpResponseMessage> DeleteByIdAsync(int id)
        {
            return await HTTPManager.DeleteAsync(address + "/" + id);
        }
        public async void DeleteAllAsync()
        {
            User[] arrUser = await GetAllAsync(0, 20);

            while (arrUser.Length > 0)
            {
                foreach (User user in arrUser)
                {
                    _ = DeleteByIdAsync(user.Id);
                }
                arrUser = await GetAllAsync(0, 20);
            }
        }
        public async Task<User[]> GetAllAsync(int page, int size)
        {
            ServerResponse<User> res = JsonConvert.DeserializeObject<ServerResponse<User>>(
                await (
                    await HTTPManager.GetAsync(address, $"page={page}&size={size}")
                ).Content.ReadAsStringAsync()
            );
            return res.content;
        }
        public static async Task<User[]> GetAllStaticAsync(int page, int size)
        {
            ServerResponse<User> res = JsonConvert.DeserializeObject<ServerResponse<User>>(
                await HTTPManager.GetAsync(
                        address, $"page={page}&size={size}"
                    ).Result.Content.ReadAsStringAsync()
                );
            return res.content;
        }
        public async Task<User> GetOfAsync(int id)
        {
            HttpResponseMessage responseMessage = await HTTPManager.GetAsync(address + "/" + id);
            return JsonConvert.DeserializeObject<ServerResponse<User>>(
                    await responseMessage.Content.ReadAsStringAsync()
                ).content[0];
        }
        public async Task<User[]> UsersFromListAsync(IEnumerable<int> listId)
        {
            List<User> resultList = new List<User>();
            foreach (int id in listId)
            {
                resultList.Add(await GetOfAsync(id));
            }
            return resultList.ToArray();
        }
    }
}