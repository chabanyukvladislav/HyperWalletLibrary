using HyperWalletLibrary.Model;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using System.Net.Http;

namespace HyperWalletLibrary.Api
{
    public class AbstractHyperWalletApi<T> where T : IHyperWalletModel
    {
        private const string MainAddress = @"https://api.sandbox.hyperwallet.com/rest/v3/";

        protected readonly IHyperWalletSender<T> Sender;
        protected HttpResponseMessage Response;
        protected IHyperWalletAccount Account;

        private string Address { get; set; }

        protected AbstractHyperWalletApi(string type, string token, string localAddress, IHyperWalletAccount account)
        {
            Address = GenerateAddress(type, token, localAddress);
            Sender = new HyperWalletSender<T>(account);
            Account = account;
        }

        public virtual async Task<Response<T>> GetAsync()
        {
            Response = await Sender.GetAsync(Address);
            if (!Response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + Response.StatusCode);
            IGetterFromHttpResponseMessage<Response<T>> getter = new ContentFromHttpResponseGetter<Response<T>>(Response);
            Response<T> result = await getter.GetAsync();
            if (result.Count > 10)
                result = await GetAll(result);
            return result;
        }

        public virtual async Task<T> GetAsync(string token)
        {
            GenerateAddress(token);
            Response = await Sender.GetAsync(Address);
            if (!Response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + Response.StatusCode);
            IGetterFromHttpResponseMessage<T> getter = new ContentFromHttpResponseGetter<T>(Response);
            return await getter.GetAsync();
        }
        public virtual async Task<T> PostAsync(T item)
        {
            GenerateAddress();
            Response = await Sender.PostAsync(Address, item);
            if (!Response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + Response.StatusCode);
            IGetterFromHttpResponseMessage<T> getter = new ContentFromHttpResponseGetter<T>(Response);
            return await getter.GetAsync();
        }
        public virtual async Task<T> PutAsync(string token, T item)
        {
            GenerateAddress(token);
            Response = await Sender.PutAsync(Address, item);
            if (!Response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + Response.StatusCode);
            IGetterFromHttpResponseMessage<T> getter = new ContentFromHttpResponseGetter<T>(Response);
            return await getter.GetAsync();
        }

        private static string GenerateAddress(string type, string token, string localAddress)
        {
            if (string.IsNullOrWhiteSpace(type))
                return MainAddress;
            if (string.IsNullOrWhiteSpace(token))
                return string.Format("{0}{1}/", MainAddress, type);
            string address = string.Format("{0}{1}/{2}/{3}/", MainAddress, type, token, localAddress);
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
                Response = await Sender.GetAsync(address);
                IGetterFromHttpResponseMessage<Response<T>> getter = new ContentFromHttpResponseGetter<Response<T>>(Response);
                Response<T> get = await getter.GetAsync();
                if (get?.Data != null)
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