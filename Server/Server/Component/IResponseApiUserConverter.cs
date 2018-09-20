using HyperWalletLibrary.Model;

namespace Server.Component
{
    public interface IResponseApiUserConverter<T> : IConverter<T, Response<User>>
    {

    }
}
