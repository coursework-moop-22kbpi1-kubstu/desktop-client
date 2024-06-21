using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.ControllersHTTP;
using WindowsFormsApp.Model.Entities;
using System.Windows.Forms;

namespace WindowsFormsApp.Model.Provider
{
    public class LoginProviderAPI
    {
        private class Token
        {
            public string token;
        }
        public class ServerResponse
        {
            public HttpResponseMessage responseMessage;
            public IUserProvideAPI iUserProvideAPI;
            public INotificationProviderAPI iNotificationProviderAPI;
        }

        private ProviderFactory.IUserProviderAPIFactory factoryUser;
        private ProviderFactory.INotificationProviderAPIFactory factoryNotification;

        public ProviderFactory.IUserProviderAPIFactory FactoryUser
        {
            get { return factoryUser; }
        }
        public ProviderFactory.INotificationProviderAPIFactory FactoryNotification
        {
            get { return factoryNotification; }
        }

        public LoginProviderAPI(ProviderFactory.IUserProviderAPIFactory factoryUser, ProviderFactory.INotificationProviderAPIFactory factoryNotification)
        {
            this.factoryUser = factoryUser;
            this.factoryNotification = factoryNotification;
        }

        public async Task<HttpResponseMessage> SignupAsync(string username, string login, string password)
        {
            return await HTTPManager.PostAsync("http://83.147.247.105:8080/auth/signup", GetJsonObj(username, login, password));
        }

        public async Task<ServerResponse> LoginAsync(string login, string password)
        {
            ServerResponse serverResponse = new ServerResponse();

            serverResponse.responseMessage = await HTTPManager.PostAsync("http://83.147.247.105:8080/auth/login", GetJsonObj(login, password));

            Token token = JsonConvert.DeserializeObject<Token>(await serverResponse.responseMessage.Content.ReadAsStringAsync());
            HTTPManager.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.token);

            serverResponse.iUserProvideAPI = factoryUser.GetProviderAPI();
            serverResponse.iNotificationProviderAPI = factoryNotification.GetProviderAPI();

            return serverResponse;
        }

        public async Task<HttpResponseMessage> LogoutAsync()
        {
            HttpResponseMessage res = await HTTPManager.PostAsync("http://83.147.247.105:8080/auth/logout", string.Empty);
            HTTPManager.HttpClient.DefaultRequestHeaders.Remove("Authorization");
            return res;
        }

        private string GetJsonObj(string login, string password)
        {
            return "{\"login\":\"" + login + "\",\"password\":\"" + password + "\"}";
        }
        private string GetJsonObj(string username, string login, string password)
        {
            return
                "{\"username\":\"" + username + "\",\"login\":\"" + login + "\",\"password\":\"" + password + "\"}";
        }
    }
}
