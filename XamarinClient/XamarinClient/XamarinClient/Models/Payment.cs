namespace XamarinClient.Models
{
    public class Payment: IModel
    {
        public string Token { get; set; }
        public double Amount { get; set; }
        public string Id { get; set; }
        public string DestinationToken { get; set; }
        public string ExpiresOn { get; set; }
        public string Notes { get; set; }
    }
}
