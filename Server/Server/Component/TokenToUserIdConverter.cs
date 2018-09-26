using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Server.Component
{
    public class TokenToUserIdConverter : ITokenConverter<string>
    {
        private const string ID_CLAIM_TYPE = "sub";

        public string Content { get; set; }

        public TokenToUserIdConverter(string content = null)
        {
            Content = content;
        }

        public string Convert()
        {
            if (Content == null) return null;
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken security = handler.ReadJwtToken(Content);
            string id = security.Claims.FirstOrDefault(el => el.Type == ID_CLAIM_TYPE).Value;
            return id;
        }
    }
}
