using HyperWalletLibrary.Model;

namespace Server.Component
{
    interface IResponseApiPaymentConverter<T> : IConverter<T, Response<Payment>>
    {
    }
}
