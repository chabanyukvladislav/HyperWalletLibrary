using System;
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
            HyperWalletLibrary.Model.Payment payment = new HyperWalletLibrary.Model.Payment();
            payment.Token = Content.Token;
            payment.Amount = Content.Amount;
            payment.ClientPaymentId = Content.Id;
            payment.Currency = Content.Currency;
            payment.DestinationToken = Content.DestinationToken;
            payment.ExpiresOn = Content.ExpiresOn;
            payment.Notes = Content.Notes;
            return payment;
        }
    }
}
