using System.Collections.Generic;
using HyperWalletLibrary.Model;
using Server.Component;
using Xunit;

namespace ServerXUnitTests.ComponentTest
{
    public class ResponseApiUserToListUserConverterTest
    {
        [Fact]
        public void Convert_Count_MoreThen_0()
        {
            //Arrange
            Response<User> response = new Response<User>()
            {
                Data = new List<User>()
                {
                    new User()
                    {
                        Token = "token"
                    }
                }
            };
            ResponseApiUserToListUserConverter converter = new ResponseApiUserToListUserConverter(response);

            //Act
            List<Server.Database.Model.User> result = converter.Convert();

            //Assert
            Assert.True(result.Count > 0);
        }
    }
}
