using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Components
{
    public interface IHyperWalletSenderSettings<T> where T : IHyperWalletModel
    {
        HttpType Type { get; set; }
        T Data { get; set; }
    }
}