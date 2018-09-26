using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinClient.Models;
using XamarinClient.OAuth;

namespace XamarinClient.Controllers
{
    class UserController : IController<User>
    {
        private const string ADDRESS = "http://localhost:11801/api/users/";

        private readonly HttpClient _client;
        private HttpResponseMessage _response;

        public UserController()
        {
            _client = new HttpClient();
            _response = new HttpResponseMessage();
            if (OAuthController.Token != null)
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(OAuthController.Token.Token_Type, OAuthController.Token.Access_Token);
            OAuthController.TokenSubject.Subscribe(TokenChanged);
        }

        private void TokenChanged(Token value)
        {
            if (value != null)
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(value.Token_Type, value.Access_Token);
            else
                _client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<List<User>> GetAsync()
        {
            try
            {
                _response = await _client.GetAsync(ADDRESS);
                string content = await _response.Content.ReadAsStringAsync();
                List<User> list = JsonConvert.DeserializeObject<List<User>>(content);
                return list;
            }
            catch (Exception)
            {
                return new List<User>();
            }
        }

        public async Task<User> GetAsync(string id)
        {
            try
            {
                _response = await _client.GetAsync(ADDRESS + id);
                string content = await _response.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(content);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> PostAsync(User value)
        {
            try
            {
                string json = JsonConvert.SerializeObject(value);
                HttpContent content = new StringContent(json, null, "application/json");
                _response = await _client.PostAsync(ADDRESS, content);
                return _response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> PutAsync(string id, User value)
        {
            try
            {
                string json = JsonConvert.SerializeObject(value);
                HttpContent content = new StringContent(json, null, "application/json");
                _response = await _client.PutAsync(ADDRESS + id, content);
                return _response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
