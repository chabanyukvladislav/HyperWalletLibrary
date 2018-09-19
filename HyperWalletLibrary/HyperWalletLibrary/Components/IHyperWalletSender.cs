using System.Net.Http;
using System.Threading.Tasks;
using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Components
{
    public interface IHyperWalletSender<T> where T: IHyperWalletModel
    {
        Task<HttpResponseMessage> SendAsync(string address, IHyperWalletSenderSettings<T> settings);
        Task<HttpResponseMessage> GetAsync(string address);
        Task<HttpResponseMessage> PostAsync(string address, T item);
        Task<HttpResponseMessage> PutAsync(string address, T item);
    }
}
