using Server.Component;
using Server.Database.Model;
using Xunit;

namespace ServerXUnitTests.ComponentTest
{
    public class UserToApiUserConverterTest
    {
        [Fact]
        public void Convert_Token_NotNull()
        {
            //Arrange
            User user = new User()
            {
                Token = "Token"
            };
            UserToApiUserConverter converter = new UserToApiUserConverter(user);

            //Act
            HyperWalletLibrary.Model.User result = converter.Convert();

            //Assert
            Assert.True(result.Token != null);
        }
    }
}
