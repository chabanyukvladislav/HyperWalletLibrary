using System.IdentityModel.Tokens.Jwt;
using Server.Component;
using Xunit;

namespace ServerXUnitTests.ComponentTest
{
    public class TokenToUserIdConverterTest
    {
        [Fact]
        public void Convert_True()
        {
            //Arrange
            JwtPayload payload = new JwtPayload
            {
                ["sub"] = "mySub"
            };
            JwtSecurityToken security = new JwtSecurityToken(new JwtHeader(), payload);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            string token = handler.WriteToken(security);
            TokenToUserIdConverter converter = new TokenToUserIdConverter(token);

            //Act
            string result = converter.Convert();

            //Assert
            Assert.Equal("mySub", result);
        }
    }
}
