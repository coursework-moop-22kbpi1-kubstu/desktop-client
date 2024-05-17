using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp.Model.ControllersHTTP
{
    public class HTTPManager
    {
        protected static HttpClient httpClient = new HttpClient();
        public static async Task<HttpResponseMessage> Post(string address, Dictionary<string, string> dictionaryParams)
        {
            try
            {
                Uri uri = new Uri(address);
                StringContent content = new StringContent(JsonConvert.SerializeObject(dictionaryParams), Encoding.UTF8, "application/json");
                return await httpClient.PostAsync(address, content);
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
        public static async Task<HttpResponseMessage> Post(string address, string jsonObj)
        {
            try
            {
                Uri uri = new Uri(address);
                StringContent content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                return await httpClient.PostAsync(address, content);
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
        public static async Task<HttpResponseMessage> Get(string address, string GETParameters)
        {
            try
            {
                Uri uri = new Uri(address);
                return httpClient.GetAsync(address + "?" + GETParameters).Result;
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
        public static async Task<HttpResponseMessage> Get(string address)
        {
            try
            {
                Uri uri = new Uri(address);
                return httpClient.GetAsync(address).Result;
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
    }
}
