using System;
using HyperWalletLibrary.Components;
using HyperWalletLibrary.Model;
using Xunit;

namespace HyperWalletLibraryXUnitTests.ApiTest
{
    public class PaymentTests
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
            HyperWalletLibrary.Api.Payment api = new HyperWalletLibrary.Api.Payment(account);

            //Act
            Response<Payment> response = await api.GetAsync();

            //Assert
            Assert.True(response.Count > 0);
        }

        [Fact]
        public async void GetAsync_WithToken_LinksCount_MoreThen_0()
        {
            //Arrange
            string token = "pmt-9ba25552-5717-423f-ac6b-b86f2946dd58";
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
            HyperWalletLibrary.Api.Payment api = new HyperWalletLibrary.Api.Payment(account);

            //Act
            Payment response = await api.GetAsync(token);

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
            HyperWalletLibrary.Api.Payment api = new HyperWalletLibrary.Api.Payment(account);
            int id = new Random().Next(100000000, 1000000000);
            Payment item = new Payment()
            {
                Amount = 20,
                ClientPaymentId = id.ToString(),
                Currency = "USD",
                DestinationToken = "usr-4beda015-edb5-4dd1-a881-60ae59c8db50"
            };

            //Act
            Payment response = await api.PostAsync(item);

            //Assert
            Assert.True(response.Links.Count > 0);
        }
    }
}
