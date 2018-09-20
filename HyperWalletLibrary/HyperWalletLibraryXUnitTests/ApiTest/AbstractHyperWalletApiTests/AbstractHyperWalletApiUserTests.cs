using System;
using HyperWalletLibrary.Components;
using HyperWalletLibrary.Model;
using HyperWalletLibraryXUnitTests.ApiTest.Component.ConcreteHyperWalletApi;
using Xunit;

namespace HyperWalletLibraryXUnitTests.ApiTest.AbstractHyperWalletApiTests
{
    public class AbstractHyperWalletApiUserTests
    {
        [Fact]
        public async void GetAsync_Count_MoreThen_0()
        {
            //Arrange
            IHyperWalletAccount account = new HyperWalletAccount
            {
                Main = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-91b2bb2f-88c4-4a5d-b6ae-ef24b25567a3",
                    Username = "restapiuser@15472201613"
                },
                Portal = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                    Username = "restapiuser@15472221611"
                }
            };
            ConcreteHyperWalletApiUser api = new ConcreteHyperWalletApiUser(account);

            //Act
            Response<User> response = await api.GetAsync();

            //Assert
            Assert.True(response.Count > 0);
        }

        [Fact]
        public async void GetAsync_WithToken_LinksCount_MoreThen_0()
        {
            //Arrange
            string token = "usr-01f5cfa0-5507-4d14-a9f8-df0791b5eea9";
            IHyperWalletAccount account = new HyperWalletAccount
            {
                Main = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-91b2bb2f-88c4-4a5d-b6ae-ef24b25567a3",
                    Username = "restapiuser@15472201613"
                },
                Portal = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                    Username = "restapiuser@15472221611"
                }
            };
            ConcreteHyperWalletApiUser api = new ConcreteHyperWalletApiUser(account);

            //Act
            User response = await api.GetAsync(token);

            //Assert
            Assert.True(response.Links.Count > 0);
        }

        [Fact]
        public async void PostAsync_LinksCount_MoreThen_0()
        {
            //Arrange
            IHyperWalletAccount account = new HyperWalletAccount
            {
                Main = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-91b2bb2f-88c4-4a5d-b6ae-ef24b25567a3",
                    Username = "restapiuser@15472201613"
                },
                Portal = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                    Username = "restapiuser@15472221611"
                }
            };
            ConcreteHyperWalletApiUser api = new ConcreteHyperWalletApiUser(account);
            int id = new Random().Next(100000000, 1000000000);
            User item = new User()
            {
                ProfileType = ProfileTypes.INDIVIDUAL,
                ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                ClientUserId = "t-" + id,
                FirstName = "John",
                LastName = "Developer",
                Email = string.Format("t-{0}@email.com", id),
                DateOfBirth = new DateTime(1991, 2, 15),
                Country = "US",
                StateProvince = "CA",
                AddressLine1 = "575 Market St",
                City = "San Francisco",
                PostalCode = "94105"
            };

            //Act
            User response = await api.PostAsync(item);

            //Assert
            Assert.True(response.Links.Count > 0);
        }

        [Fact]
        public async void PutAsync_LinksCount_MoreThen_0()
        {
            //Arrange
            string token = "usr-01f5cfa0-5507-4d14-a9f8-df0791b5eea9";
            IHyperWalletAccount account = new HyperWalletAccount
            {
                Main = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-91b2bb2f-88c4-4a5d-b6ae-ef24b25567a3",
                    Username = "restapiuser@15472201613"
                },
                Portal = new HyperWalletProgram()
                {
                    Password = "Ke002308!!",
                    ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                    Username = "restapiuser@15472221611"
                }
            };
            ConcreteHyperWalletApiUser api = new ConcreteHyperWalletApiUser(account);
            User item = new User()
            {
                LastName = "Ddd"
            };

            //Act
            User response = await api.PutAsync(token, item);

            //Assert
            Assert.True(response.Links.Count > 0);
        }
    }
}
