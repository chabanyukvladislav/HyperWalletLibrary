using Server.Database.Model;

namespace Server.Component
{
    interface IPaymentConverter<T> : IConverter<T, Payment>
    {
    }
}
