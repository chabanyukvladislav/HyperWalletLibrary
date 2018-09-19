using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Components
{
    public class HyperWalletSenderSettings<T> : IHyperWalletSenderSettings<T> where T : IHyperWalletModel
    {
        public HttpType Type { get; set; } = HttpType.Get;
        public T Data { get; set; }
    }
}