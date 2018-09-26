using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace XamarinClient.Components
{
    class TokenToNickConverter : ITokenConverter<string>
    {
        private const string NICK_CLAIM_TYPE = "nickname";

        public string Content { get; set; }

        public TokenToNickConverter(string content = null)
        {
            Content = content;
        }

        public string Convert()
        {
            if (string.IsNullOrEmpty(Content)) return null;
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken security = handler.ReadJwtToken(Content);
            string nick = security.Claims.FirstOrDefault(el => el.Type == NICK_CLAIM_TYPE)?.Value;
            return nick;
        }
    }
}
