using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Server.Service.Model;

namespace Server.Service
{
    public class TokenService : ITokenService
    {
        private const string ADDRESS = "https://itstep1511.eu.auth0.com/oauth/token";
        private const string CLIENT_ID = "4QYwxAh36xHekQWPd3TL00J9tYfcvQIg";
        private const string CLIENT_SECRET = "vZcFcZoHTrpb9lT--dQTSXoZrSryAE43Ehn0B7WDq7Bf9isOFSdOmBPEqnmUG9Pq";
        private const string AUDIENCE = "https://hyperwalletlibrary/api";
        private const string GRANT_TYPE = "client_credentials";

        private readonly HttpClient _client;

        public TokenService()
        {
            _client = new HttpClient();
        }

        public async Task<Token> GetTokenAsync()
        {
            try
            {
                string json = GenerateJson();
                HttpContent content = new StringContent(json, null, "application/json");
                HttpResponseMessage response = await _client.PostAsync(ADDRESS, content);
                string responseContent = await response.Content.ReadAsStringAsync();
                Token token = JsonConvert.DeserializeObject<Token>(responseContent);
                return token;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GenerateJson()
        {
            StringWriter json = new StringWriter();
            JsonWriter jsonWriter = new JsonTextWriter(json);
            jsonWriter.WriteStartObject();
            jsonWriter.WritePropertyName(nameof(CLIENT_ID).ToLower());
            jsonWriter.WriteValue(CLIENT_ID);
            jsonWriter.WritePropertyName(nameof(CLIENT_SECRET).ToLower());
            jsonWriter.WriteValue(CLIENT_SECRET);
            jsonWriter.WritePropertyName(nameof(AUDIENCE).ToLower());
            jsonWriter.WriteValue(AUDIENCE);
            jsonWriter.WritePropertyName(nameof(GRANT_TYPE).ToLower());
            jsonWriter.WriteValue(GRANT_TYPE);
            jsonWriter.WriteEnd();
            return json.ToString();
        }
    }
}
