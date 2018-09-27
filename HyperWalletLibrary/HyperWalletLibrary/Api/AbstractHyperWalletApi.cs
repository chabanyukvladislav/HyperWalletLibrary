using HyperWalletLibrary.Model;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using System.Net.Http;

namespace HyperWalletLibrary.Api
{
    public class AbstractHyperWalletApi<T> where T : IHyperWalletModel
    {
        private const string MAIN_ADDRESS = @"https://api.sandbox.hyperwallet.com/rest/v3/";

        protected readonly IHyperWalletSender<T> _sender;
        protected HttpResponseMessage _response;
        protected IHyperWalletAccount _account;

        private string Address { get; set; }

        protected AbstractHyperWalletApi(string type, string token, string localAddress, IHyperWalletAccount account)
        {
            Address = GenerateAddress(type, token, localAddress);
            _sender = new HyperWalletSender<T>(account);
            _account = account;
        }

        public virtual async Task<Response<T>> GetAsync()
        {
            _response = await _sender.GetAsync(Address);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            IGetterFromHttpResponseMessage<Response<T>> getter = new ContentFromHttpResponseGetter<Response<T>>(_response);
            Response<T> result = await getter.GetAsync();
            if (result.Count > 10)
                result = await GetAll(result);
            return result;
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

        private string GenerateAddress(string type, string token, string localAddress)
        {
            if (string.IsNullOrWhiteSpace(type))
                return MAIN_ADDRESS;
            if (string.IsNullOrWhiteSpace(token))
                return string.Format("{0}{1}/", MAIN_ADDRESS, type);
            string address = string.Format("{0}{1}/{2}/{3}/", MAIN_ADDRESS, type, token, localAddress);
            return address;
        }
        private void GenerateAddress(string token = "")
        {
            if (string.IsNullOrWhiteSpace(token))
                return;
            Address = string.Format("{0}{1}", Address, token);
        }

        private async Task<Response<T>> GetAll(Response<T> result)
        {
            for (int i = 10; i < result.Count; i += 10)
            {
                string address = string.Format("{0}?offset={1}", Address, i);
                _response = await _sender.GetAsync(address);
                IGetterFromHttpResponseMessage<Response<T>> getter = new ContentFromHttpResponseGetter<Response<T>>(_response);
                Response<T> get = await getter.GetAsync();
                if (get != null && get.Data != null)
                    foreach (T t in get.Data)
                    {
                        result.Data.Add(t);
                        result.Limit++;
                    }
            }

            return result;
        }
    }
}