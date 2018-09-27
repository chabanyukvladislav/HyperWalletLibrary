using System.Collections.Generic;
using HyperWalletLibrary.Model;
using Server.Component.Payments;
using Xunit;

namespace ServerXUnitTests.ComponentTest
{
    public class ResponseApiPaymentToListPaymentConverterTest
    {
        [Fact]
        public void Convert_Count_MoreThen_0()
        {
            //Arrange
            Response<Payment> response = new Response<Payment>()
            {
                Data = new List<Payment>()
                {
                    new Payment()
                    {
                        Token = "token"
                    }
                }
            };
            ResponseApiPaymentToListPaymentConverter converter = new ResponseApiPaymentToListPaymentConverter(response);

            //Act
            List<Server.Database.Model.Payment> result = converter.Convert();

            //Assert
            Assert.True(result.Count > 0);
        }
    }
}
