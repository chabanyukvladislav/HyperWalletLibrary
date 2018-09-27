using Server.Component.Payments;
using Server.Database.Model;
using Xunit;

namespace ServerXUnitTests.ComponentTest
{
    public class PaymentToApiPaymentConverterTest
    {
        [Fact]
        public void Convert_Token_NotNull()
        {
            //Arrange
            Payment payment = new Payment()
            {
                Token = "Token"
            };
            PaymentToApiPaymentConverter converter = new PaymentToApiPaymentConverter(payment);

            //Act
            HyperWalletLibrary.Model.Payment result = converter.Convert();

            //Assert
            Assert.True(result.Token != null);
        }
    }
}
