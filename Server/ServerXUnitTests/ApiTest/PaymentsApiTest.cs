using Server.Api;
using System;
using System.Collections.Generic;
using Xunit;

namespace ServerXUnitTests.ApiTest
{
    public class PaymentsApiTest
    {
        [Fact]
        public async void GetAsync_NotNull()
        {
            //Arrange
            PaymentApiWorker worker = new PaymentApiWorker();

            //Act
            List<Server.Database.Model.Payment> list = await worker.GetAsync();

            //Assert
            Assert.True(list != null);
        }

        [Fact]
        public async void GetAsync_WithToken_NotNull()
        {
            //Arrange
            PaymentApiWorker worker = new PaymentApiWorker();
            string token = "pmt-28df87ac-2280-466c-a788-8151e6d6b179";

            //Act
            Server.Database.Model.Payment payment = await worker.GetAsync(token);

            //Assert
            Assert.True(payment != null);
        }

        [Fact]
        public async void PostAsync_NotNull()
        {
            //Arrange
            PaymentApiWorker worker = new PaymentApiWorker();
            string id = new Random().Next().ToString();
            Server.Database.Model.Payment user = new Server.Database.Model.Payment()
            {
                Amount = 20,
                Id = id.ToString(),
                Currency = "USD",
                DestinationToken = "usr-4beda015-edb5-4dd1-a881-60ae59c8db50"
            };

            //Act
            Server.Database.Model.Payment result = await worker.PostAsync(user);

            //Assert
            Assert.True(result != null);
        }
    }
}
