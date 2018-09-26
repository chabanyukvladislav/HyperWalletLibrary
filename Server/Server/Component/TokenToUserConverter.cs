using Server.Database.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Server.Component
{
    public class TokenToUserConverter : ITokenConverter<User>
    {
        private const string ID_CLAIM_TYPE = "sub";
        private const string NAME_CLAIM_TYPE = "given_name";
        private const string SURNAME_CLAIM_TYPE = "family_name";
        private const string EMAIL_CLAIM_TYPE = "email";

        public string Content { get; set; }

        public TokenToUserConverter(string content = null)
        {
            Content = content;
        }

        public User Convert()
        {
            if (Content == null) return null;
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken security = handler.ReadJwtToken(Content);
            User user = new User
            {
                Id = security.Claims.FirstOrDefault(el => el.Type == ID_CLAIM_TYPE)?.Value,
                Email = security.Claims.FirstOrDefault(el => el.Type == EMAIL_CLAIM_TYPE)?.Value,
                FirstName = security.Claims.FirstOrDefault(el => el.Type == NAME_CLAIM_TYPE)?.Value,
                LastName = security.Claims.FirstOrDefault(el => el.Type == SURNAME_CLAIM_TYPE)?.Value
            };
            return user;
        }
    }
}
