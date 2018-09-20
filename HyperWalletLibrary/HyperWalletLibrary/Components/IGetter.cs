using System.Net.Http;
using System.Threading.Tasks;
using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Components
{
    public interface IGetterFromHttpResponseMessage<T> where T : IHyperWalletModel
    {
        HttpResponseMessage Content { get; set; }

        Task<T> GetAsync();
    }
}