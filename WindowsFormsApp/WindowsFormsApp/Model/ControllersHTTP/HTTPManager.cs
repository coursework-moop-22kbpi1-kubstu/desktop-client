using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp.Model.ControllersHTTP
{
    public static class HTTPManager
    {
        private static HttpClient httpClient = new HttpClient();
        public static HttpClient HttpClient
        {
            get { return httpClient; }
            //set { httpClient = value; }
        }
        public static async Task<HttpResponseMessage> PostAsync(string address, string jsonObj)
        {
            try
            {
                StringContent content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                return await httpClient.PostAsync(address, content);
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
        public static async Task<HttpResponseMessage> GetAsync(string address, string GETParameters = null)
        {
            string arg;
            if (GETParameters != null && GETParameters != "") { arg = address + "?" + GETParameters; }
            else { arg = address; }
            try
            {
                return await httpClient.GetAsync(arg);
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
        public static async Task<HttpResponseMessage> PatchAsync(string address, string jsonObj)
        {
            try
            {
                StringContent content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                var method = new HttpMethod("PATCH");
                var request = new HttpRequestMessage(method, address)
                {
                    Content = content
                };

                return await httpClient.SendAsync(request);
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
        public static async Task<HttpResponseMessage> DeleteAsync(string address)
        {
            try
            {
                return await httpClient.DeleteAsync(address);
            }
            catch
            {
                throw new Exception("Ошибка при попытке запроса");
            }
        }
    }
}
