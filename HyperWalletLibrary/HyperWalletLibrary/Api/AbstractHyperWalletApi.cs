using HyperWalletLibrary.Model;
using System.Security;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace HyperWalletLibrary.Api
{
    public class AbstractHyperWalletApi<T> where T : IHyperWalletModel
    {
        private const string MAIN_ADDRESS = @"https://api.sandbox.hyperwallet.com/rest/v3/users/";

        private string Address { get; set; }

        protected readonly IHyperWalletSender<T> _sender;
        protected HttpResponseMessage _response;

        protected AbstractHyperWalletApi(string userToken, string localAddress, string programToken, string username, SecureString password)
        {
            Address = GenerateAddress(userToken, localAddress);
            _sender = new HyperWalletSender<T>(programToken, username, password);
        }

        public virtual async Task<Response<T>> GetAsync(string token = "")
        {
            GenerateAddress(token);
            _response = await _sender.GetAsync(Address);
            return await GetContent();
        }
        public virtual async Task<Response<T>> PostAsync(T item)
        {
            GenerateAddress();
            _response = await _sender.PostAsync(Address, item);
            return await GetContent();
        }
        public virtual async Task<Response<T>> PutAsync(string token, T item)
        {
            GenerateAddress(token);
            _response = await _sender.PutAsync(Address, item);
            return await GetContent();
        }

        private string GenerateAddress(string userToken, string localAddress)
        {
            if (string.IsNullOrWhiteSpace(userToken))
                return MAIN_ADDRESS;
            if (string.IsNullOrWhiteSpace(localAddress))
                throw new ArgumentNullException("LocalAddress can not be null or empty");
            string address = string.Format($"{0}{1}/{2}/", MAIN_ADDRESS, userToken, localAddress);
            return address;
        }
        private void GenerateAddress(string token = "")
        {
            if (string.IsNullOrWhiteSpace(token))
                return;
            Address = string.Format($"{0}{1}", Address, token);
        }

        private async Task<Response<T>> GetContent()
        {
            string content = await _response.Content.ReadAsStringAsync();
            Response<T> data = JsonConvert.DeserializeObject<Response<T>>(content);
            return data;
        }
    }
}