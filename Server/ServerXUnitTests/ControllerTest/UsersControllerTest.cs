using Microsoft.EntityFrameworkCore;
using Server.Controllers;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace ServerXUnitTests.ControllerTest
{
    public class UsersControllerTest
    {
        [Fact]
        public async void Get_Count_MoreThen_0()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            UsersController controller = new UsersController(context);

            //Act
            List<User> list = await controller.Get();

            //Assert
            Assert.True(list.Count > 0);
        }

        [Fact]
        public async void GetAsync_WithToken_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            UsersController controller = new UsersController(context);
            string clientId = "585148410";

            //Act
            User user = await controller.Get(clientId);

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
            UsersController controller = new UsersController(context);
            string id = new Random().Next().ToString();
            User user = new User()
            {
                AddressLine1 = "Address",
                City = "San Francisco",
                Country = "US",
                Email = string.Format("email{0}@email.com", id),
                FirstName = "Name",
                Id = id,
                LastName = "Surname",
                MiddleName = "Middle",
                PostalCode = "00000",
                StateProvince = "CA"
            };

            //Act
            bool result = await controller.Post(user);

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
            UsersController controller = new UsersController(context);
            string clientId = "585148410";
            User user = new User()
            {
                AddressLine1 = "Address" + new Random().Next().ToString()
            };

            //Act
            bool result = await controller.Put(clientId, user);

            //Assert
            Assert.True(result);
        }
    }
}
