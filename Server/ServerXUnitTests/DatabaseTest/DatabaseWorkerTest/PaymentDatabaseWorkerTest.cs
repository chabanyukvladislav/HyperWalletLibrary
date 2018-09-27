using System;
using Server.Database;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Server.Database.DatabaseContext;
using Xunit;

namespace ServerXUnitTests.DatabaseTest.DatabaseWorkerTest
{
    public class PaymentDatabaseWorkerTest
    {
        [Fact]
        public async void GetAsync_Count_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            PaymentDatabaseWorker worker = new PaymentDatabaseWorker(context);

            //Act
            List<Server.Database.Model.Payment> list = await worker.GetAsync();

            //Assert
            Assert.True(list != null);
        }

        [Fact]
        public async void GetAsync_WithId_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            PaymentDatabaseWorker worker = new PaymentDatabaseWorker(context);
            string clientId = "1458303177";

            //Act
            Server.Database.Model.Payment payment = await worker.GetAsync(clientId);

            //Assert
            Assert.True(payment != null);
        }

        [Fact]
        public async void PostAsync_True()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            PaymentDatabaseWorker worker = new PaymentDatabaseWorker(context);
            string id = new Random().Next().ToString();
            Server.Database.Model.Payment payment = new Server.Database.Model.Payment()
            {
                Amount = 20,
                Id = id.ToString(),
                Currency = "USD",
                DestinationToken = "usr-4beda015-edb5-4dd1-a881-60ae59c8db50"
            };

            //Act
            bool result = await worker.PostAsync(payment);

            //Assert
            Assert.True(result);
        }
    }
}
