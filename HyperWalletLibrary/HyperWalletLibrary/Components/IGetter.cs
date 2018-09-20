using System.Net.Http;
using System.Threading.Tasks;
using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Components
{
    internal interface IGetterFromHttpResponseMessage<T> where T : IHyperWalletModel
    {
        HttpResponseMessage Content { get; set; }

        Task<T> GetAsync();
    }
}