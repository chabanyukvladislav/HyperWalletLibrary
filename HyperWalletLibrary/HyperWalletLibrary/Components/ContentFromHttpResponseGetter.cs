using System.Net.Http;
using System.Threading.Tasks;
using HyperWalletLibrary.Model;
using Newtonsoft.Json;

namespace HyperWalletLibrary.Components
{
    public class ContentFromHttpResponseGetter<T> : IGetterFromHttpResponseMessage<T> where T : IHyperWalletModel
    {
        public HttpResponseMessage Content { get; set; }

        public ContentFromHttpResponseGetter(HttpResponseMessage content)
        {
            Content = content;
        }

        public async Task<T> GetAsync()
        {
            string content = await Content.Content.ReadAsStringAsync();
            T data = JsonConvert.DeserializeObject<T>(content);
            return data;
        }
    }
}
