using HyperWalletLibrary.Model.PaymentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("HyperWalletLibraryXUnitTests")]

namespace HyperWalletLibrary.Model
{
    public class Payment : IHyperWalletModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        internal Status? Status { get; set; }
        [JsonProperty("createdOn")]
        internal DateTime? CreatedOn { get; set; }
        [JsonProperty("amount")]
        public double Amount { get; set; }
        [JsonProperty("clientPaymentId")]
        public string ClientPaymentId { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("destinationToken")]
        public string DestinationToken { get; set; }
        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }
        [JsonProperty("memo")]
        public string Memo { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("programToken")]
        internal string ProgramToken { get; set; }
        [JsonProperty("purpose")]
        internal string Purpose { get; set; }
        [JsonProperty("releaseOn")]
        public string ReleaseOn { get; set; }
        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}
