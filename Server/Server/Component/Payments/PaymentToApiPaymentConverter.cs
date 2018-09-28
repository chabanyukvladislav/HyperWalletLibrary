using Server.Database.Model;

namespace Server.Component.Payments
{
    public class PaymentToApiPaymentConverter : IPaymentConverter<HyperWalletLibrary.Model.Payment>
    {
        public Payment Content { get; set; }

        public PaymentToApiPaymentConverter(Payment content = null)
        {
            Content = content;
        }

        public HyperWalletLibrary.Model.Payment Convert()
        {
            if (Content == null) return null;
            HyperWalletLibrary.Model.Payment payment = new HyperWalletLibrary.Model.Payment
            {
                Token = Content.Token,
                Amount = Content.Amount,
                DestinationToken = Content.DestinationToken,
                ExpiresOn = Content.ExpiresOn,
                Notes = Content.Notes
            };
            return payment;
        }
    }
}
