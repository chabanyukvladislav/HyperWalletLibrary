using System;
using HyperWalletLibrary.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace HyperWalletLibrary.Components
{
    public class HyperWalletSender<T> : IHyperWalletSender<T> where T : IHyperWalletModel
    {
        private readonly HttpClient _client;
        private HttpResponseMessage _response;
        private HttpContent _content;
        private readonly IHyperWalletAccount _account;

        public HyperWalletSender(IHyperWalletAccount account)
        {
            HttpClientHandler handler = new HttpClientHandler
            {
                Credentials = new NetworkCredential(account.Portal.Username, account.Portal.Password)
            };
            _client = new HttpClient(handler);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _account = account;
        }

        public async Task<HttpResponseMessage> SendAsync(string address, IHyperWalletSenderSettings<T> settings)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(nameof(address));
            switch (settings.Type)
            {
                case HttpType.Get:
                    return await GetAsync(address);
                case HttpType.Post:
                    return await PostAsync(address, settings.Data);
                case HttpType.Put:
                    return await PutAsync(address, settings.Data);
                default:
                    throw new ArgumentNullException(nameof(settings.Type));
            }
        }

        private void SerializeContent(T data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));
            string json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatString = "yyyy-MM-ddTHH:mm:ss" });
            _content = new StringContent(json, Encoding.UTF8, "application/json");
        }

        public async Task<HttpResponseMessage> GetAsync(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(nameof(address));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _account.Portal.ProgramToken);
            _response = await _client.GetAsync(address);
            return _response;
        }

        public async Task<HttpResponseMessage> PostAsync(string address, T item)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(nameof(address));
            SerializeContent(item);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _account.Portal.ProgramToken);
            _response = await _client.PostAsync(address, _content);
            return _response;
        }

        public async Task<HttpResponseMessage> PutAsync(string address, T item)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(nameof(address));
            SerializeContent(item);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _account.Portal.ProgramToken);
            _response = await _client.PutAsync(address, _content);
            return _response;
        }
    }
}
