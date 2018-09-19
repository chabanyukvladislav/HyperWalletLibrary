using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    public class Response<T> : IHyperWalletModel where T : IHyperWalletModel
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
        [JsonProperty("data")]
        public List<T> Data { get; set; }
        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}
