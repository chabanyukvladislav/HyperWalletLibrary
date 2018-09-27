using Microsoft.EntityFrameworkCore;
using Server.Controllers;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace ServerXUnitTests.ControllerTest
{
    public class PaymentsControllerTest
    {
        [Fact]
        public async void Get_Count_MoreThen_0()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            PaymentsController controller = new PaymentsController(context);

            //Act
            List<Payment> list = await controller.Get();

            //Assert
            Assert.True(list.Count > 0);
        }

        [Fact]
        public async void Get_WithToken_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            PaymentsController controller = new PaymentsController(context);
            string id = "1458303177";

            //Act
            Payment user = await controller.Get(id);

            //Assert
            Assert.True(user != null);
        }

        [Fact]
        public async void PostAsync_True()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            PaymentsController controller = new PaymentsController(context);
            string id = new Random().Next().ToString();
            Payment payment = new Payment()
            {
                Amount = 20,
                Id = id.ToString(),
                Currency = "USD",
                DestinationToken = "usr-4beda015-edb5-4dd1-a881-60ae59c8db50"
            };

            //Act
            bool result = await controller.Post(payment);

            //Assert
            Assert.True(result);
        }
    }
}
