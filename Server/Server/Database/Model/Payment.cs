namespace Server.Database.Model
{
    public class Payment: IModel
    {
        public string Token { get; set; }
        public double Amount { get; set; }
        public string Id { get; set; }
        public string Currency { get; set; }
        public string DestinationToken { get; set; }
        public string ExpiresOn { get; set; }
        public string Notes { get; set; }

        public Payment() { }

        public Payment(HyperWalletLibrary.Model.Payment payment)
        {
            Token = payment.Token;
            Amount = payment.Amount;
            Id = payment.ClientPaymentId;
            Currency = payment.Currency;
            DestinationToken = payment.DestinationToken;
            ExpiresOn = payment.ExpiresOn;
            Notes = payment.Notes;
        }
    }
}
