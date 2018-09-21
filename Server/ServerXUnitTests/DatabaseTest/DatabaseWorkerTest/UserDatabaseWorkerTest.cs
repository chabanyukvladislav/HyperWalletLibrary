using System;
using Server.Database;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Server.Database.DatabaseContext;
using Xunit;

namespace ServerXUnitTests.DatabaseTest.DatabaseWorkerTest
{
    public class UserDatabaseWorkerTest
    {
        [Fact]
        public async void GetAsync_Count_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            UserDatabaseWorker worker = new UserDatabaseWorker(context);

            //Act
            List<Server.Database.Model.User> list = await worker.GetAsync();

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
            UserDatabaseWorker worker = new UserDatabaseWorker(context);
            string clientId = "585148410";

            //Act
            Server.Database.Model.User user = await worker.GetAsync(clientId);

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
            UserDatabaseWorker worker = new UserDatabaseWorker(context);
            string id = new Random().Next().ToString();
            Server.Database.Model.User user = new Server.Database.Model.User()
            {
                AddressLine1 = "Address",
                City = "City",
                Country = "Country",
                Email = string.Format("email{0}@email.com", id),
                FirstName = "Name",
                Id = id,
                LastName = "Surname",
                MiddleName = "Middle",
                PostalCode = "00000",
                StateProvince = "State"
            };

            //Act
            bool result = await worker.PostAsync(user);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public async void PutAsync_True()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            UserDatabaseWorker worker = new UserDatabaseWorker(context);
            string clientId = "585148410";
            string rand = new Random().Next().ToString();
            Server.Database.Model.User user = new Server.Database.Model.User()
            {
                AddressLine1 = "Address" + rand
            };

            //Act
            bool result = await worker.PutAsync(clientId, user);

            //Assert
            Assert.True(result);
        }
    }
}
