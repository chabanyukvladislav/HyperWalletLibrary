using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using XamarinClient.Models;
using XamarinClient.OAuth;

namespace XamarinClient.Controllers
{
    class PaymentsController : IController<Payment>
    {
        private const string ADDRESS = "http://localhost:11801/api/payments/";

        private readonly HttpClient _client;
        private HttpResponseMessage _response;

        public PaymentsController()
        {
            _client = new HttpClient();
            _response = new HttpResponseMessage();
            if (OAuthController.Token != null)
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(OAuthController.Token.Token_Type, OAuthController.Token.Access_Token);
            OAuthController.TokenSubject.Subscribe(TokenChanging);
        }

        private void TokenChanging(Token value)
        {
            if (value != null)
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(value.Token_Type, value.Access_Token);
            else
                _client.DefaultRequestHeaders.Authorization = null;
            TokenChanged?.Invoke();
        }

        public async Task<List<Payment>> GetAsync()
        {
            try
            {
                _response = await _client.GetAsync(ADDRESS);
                string content = await _response.Content.ReadAsStringAsync();
                List<Payment> list = JsonConvert.DeserializeObject<List<Payment>>(content);
                return list;
            }
            catch (Exception)
            {
                return new List<Payment>();
            }
        }

        public async Task<Payment> GetAsync(string id)
        {
            try
            {
                _response = await _client.GetAsync(ADDRESS + id);
                string content = await _response.Content.ReadAsStringAsync();
                Payment user = JsonConvert.DeserializeObject<Payment>(content);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> PostAsync(Payment value)
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

        public async Task<bool> PutAsync(string id, Payment value)
        {
            return false;
        }

        public event Action TokenChanged;
    }
}
