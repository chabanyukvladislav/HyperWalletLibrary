using Newtonsoft.Json;

namespace XamarinClient.Models
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string Access_Token { get; set; }
        [JsonProperty("token_type")]
        public string Token_Type { get; set; }
    }
}
