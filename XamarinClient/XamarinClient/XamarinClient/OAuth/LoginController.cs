using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinClient.Models;

namespace XamarinClient.OAuth
{
    class LoginController : ILoginController
    {
        private const string ADDRESS = "http://localhost:11801/api/login/";

        private readonly HttpClient _client;
        private readonly string _idToken;

        public LoginController(string idToken)
        {
            _idToken = idToken;
            _client = new HttpClient();
        }

        public async Task<Token> LoginAsync()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_idToken);
                HttpContent content = new StringContent(json, null, "application/json");
                HttpResponseMessage response = await _client.PostAsync(ADDRESS, content);
                string responseContent = await response.Content.ReadAsStringAsync();
                Token token = JsonConvert.DeserializeObject<Token>(responseContent);
                return token;
            }
            catch (Exception )
            {
                return null;
            }
        }
    }
}
