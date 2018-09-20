using HyperWalletLibrary.Model;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using System.Net.Http;
using System;

namespace HyperWalletLibrary.Api
{
    public class AbstractHyperWalletApi<T> where T : IHyperWalletModel
    {
        private const string MAIN_ADDRESS = @"https://api.sandbox.hyperwallet.com/rest/v3/users/";
        private string Address { get; set; }

        protected readonly IHyperWalletSender<T> _sender;
        protected HttpResponseMessage _response;

        protected AbstractHyperWalletApi(string userToken, string localAddress, IHyperWalletAccount account)
        {
            Address = GenerateAddress(userToken, localAddress);
            _sender = new HyperWalletSender<T>(account);
        }

        public virtual async Task<Response<T>> GetAsync()
        {
            _response = await _sender.GetAsync(Address);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            IGetterFromHttpResponseMessage<Response<T>> getter = new ContentFromHttpResponseGetter<Response<T>>(_response);
            return await getter.GetAsync();
        }
        public virtual async Task<T> GetAsync(string token)
        {
            GenerateAddress(token);
            _response = await _sender.GetAsync(Address);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            IGetterFromHttpResponseMessage<T> getter = new ContentFromHttpResponseGetter<T>(_response);
            return await getter.GetAsync();
        }
        public virtual async Task<T> PostAsync(T item)
        {
            GenerateAddress();
            _response = await _sender.PostAsync(Address, item);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            IGetterFromHttpResponseMessage<T> getter = new ContentFromHttpResponseGetter<T>(_response);
            return await getter.GetAsync();
        }
        public virtual async Task<T> PutAsync(string token, T item)
        {
            GenerateAddress(token);
            _response = await _sender.PutAsync(Address, item);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            IGetterFromHttpResponseMessage<T> getter = new ContentFromHttpResponseGetter<T>(_response);
            return await getter.GetAsync();
        }

        private string GenerateAddress(string userToken, string localAddress)
        {
            if (string.IsNullOrWhiteSpace(userToken))
                return MAIN_ADDRESS;
            if (string.IsNullOrWhiteSpace(localAddress))
                throw new ArgumentNullException("LocalAddress can not be null or empty");
            string address = string.Format("{0}{1}/{2}/", MAIN_ADDRESS, userToken, localAddress);
            return address;
        }
        private void GenerateAddress(string token = "")
        {
            if (string.IsNullOrWhiteSpace(token))
                return;
            Address = string.Format("{0}{1}", Address, token);
        }
    }
}