using Server.Service;
using Server.Service.Model;
using Xunit;

namespace ServerXUnitTests.ServiceTest
{
    public class TokenServiceTest
    {
        [Fact]
        public async void GetTokenAsync_NotNull()
        {
            //Arrange
            TokenService service = new TokenService();

            //Act
            Token token = await service.GetTokenAsync();

            //Assert
            Assert.True(token != null);
        }
    }
}
