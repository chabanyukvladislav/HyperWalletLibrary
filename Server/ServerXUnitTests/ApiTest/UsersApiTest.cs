using HyperWalletLibrary.Model;
using Server.Api;
using Server.Database.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace ServerXUnitTests.ApiTest
{
    public class UsersApiTest
    {
        [Fact]
        public async void GetAsync_Count_NotNull()
        {
            //Arrange
            UserApiWorker worker = new UserApiWorker();

            //Act
            List<User> list = await worker.GetAsync();

            //Assert
            Assert.True(list != null);
        }

        [Fact]
        public async void GetAsync_WithToken_NotNull()
        {
            //Arrange
            UserApiWorker worker = new UserApiWorker();
            string token = "usr-21a285ee-8ded-4038-8843-73ba83b28acf";

            //Act
            Server.Database.Model.User user = await worker.GetAsync(token);

            //Assert
            Assert.True(user != null);
        }

        [Fact]
        public async void PostAsync_NotNull()
        {
            //Arrange
            UserApiWorker worker = new UserApiWorker();
            string id = new Random().Next().ToString();
            Server.Database.Model.User user = new Server.Database.Model.User()
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
                ProfileType = ProfileTypes.INDIVIDUAL,
                ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                StateProvince = "CA"
            };

            //Act
            Server.Database.Model.User result = await worker.PostAsync(user);

            //Assert
            Assert.True(result != null);
        }

        [Fact]
        public async void PutAsync_NotNull()
        {
            //Arrange
            UserApiWorker worker = new UserApiWorker();
            string token = "usr-21a285ee-8ded-4038-8843-73ba83b28acf";
            Server.Database.Model.User user = new Server.Database.Model.User()
            {
                AddressLine1 = "Address" + new Random().Next().ToString()
            };

            //Act
            Server.Database.Model.User result = await worker.PutAsync(token, user);

            //Assert
            Assert.True(result != null);
        }
    }
}
