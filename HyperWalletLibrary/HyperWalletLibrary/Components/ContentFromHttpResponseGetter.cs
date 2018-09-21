using System.Net.Http;
using System.Threading.Tasks;
using HyperWalletLibrary.Model;
using Newtonsoft.Json;

namespace HyperWalletLibrary.Components
{
    public class ContentFromHttpResponseGetter<T> : IGetterFromHttpResponseMessage<T> where T : IHyperWalletModel
    {
        public HttpResponseMessage Content { get; set; }

        public async Task<T> GetAsync()
        {
            if (Content == null) return default(T);
            string content = await Content.Content.ReadAsStringAsync();
            T data = JsonConvert.DeserializeObject<T>(content);
            return data;
        }

        public ContentFromHttpResponseGetter(HttpResponseMessage content = null)
        {
            Content = content;
        }
    }
}
