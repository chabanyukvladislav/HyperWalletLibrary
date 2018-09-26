using System.Collections.Generic;
using Server.Component;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Server.Database.Model;
using Xunit;

namespace ServerXUnitTests.ComponentTest
{
    public class TokenToUserConverterTest
    {
        [Fact]
        public void Convert_NotNull()
        {
            //Arrange
            IEnumerable<Claim> claims = new List<Claim>()
            {
                new Claim("given_name","MyName"),
                new Claim("family_name","MySurname"),
                new Claim("email","myEmail"),
            };
            JwtPayload payload = new JwtPayload(claims)
            {
                ["sub"] = "mySub"
            };
            JwtSecurityToken security = new JwtSecurityToken(new JwtHeader(), payload);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            string token = handler.WriteToken(security);
            TokenToUserConverter converter = new TokenToUserConverter(token);

            //Act
            User result = converter.Convert();

            //Assert
            Assert.True(result != null);
        }
    }
}
