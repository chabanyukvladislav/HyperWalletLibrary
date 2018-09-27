using System;
using HyperWalletLibrary.Components;
using System.Net;
using HyperWalletLibrary.Model;
using Xunit;
using System.Net.Http;

namespace HyperWalletLibraryXUnitTests.ComponentTest.HyperWalletSenderTest
{
    public class HyperWalletSenderPaymentTests
    {
        [Fact]
        public async void SendAsync_Get_StatusCode_200_OK()
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
            HyperWalletSender<Payment> sender = new HyperWalletSender<Payment>(account);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/payments/";
            HyperWalletSenderSettings<Payment> settings = new HyperWalletSenderSettings<Payment>()
            {
                Type = HttpType.Get
            };

            //Act
            HttpResponseMessage response = await sender.SendAsync(address, settings);

            //Assert
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact]
        public async void SendAsync_Post_StatusCode_201_Created()
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
            HyperWalletSender<Payment> sender = new HyperWalletSender<Payment>(account);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/payments/";
            int id = new Random().Next();
            Payment item = new Payment()
            {
                Amount = 20,
                ClientPaymentId = id.ToString(),
                Currency = "USD",
                DestinationToken = "usr-4beda015-edb5-4dd1-a881-60ae59c8db50",
                ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                Purpose = "OTHER"
            };
            HyperWalletSenderSettings<Payment> settings = new HyperWalletSenderSettings<Payment>()
            {
                Type = HttpType.Post,
                Data = item
            };

            //Act
            HttpResponseMessage response = await sender.SendAsync(address, settings);

            //Assert
            Assert.True(response.StatusCode == HttpStatusCode.Created);
        }

        [Fact]
        public async void GetAsync_StatusCode_200_OK()
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
            HyperWalletSender<Payment> sender = new HyperWalletSender<Payment>(account);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/payments/";

            //Act
            HttpResponseMessage response = await sender.GetAsync(address);

            //Assert
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact]
        public async void PostAsync_StatusCode_201_Created()
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
            HyperWalletSender<Payment> sender = new HyperWalletSender<Payment>(account);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/payments/";
            int id = new Random().Next(100000000, 1000000000);
            Payment item = new Payment()
            {
                Amount = 20,
                ClientPaymentId = id.ToString(),
                Currency = "USD",
                DestinationToken = "usr-4beda015-edb5-4dd1-a881-60ae59c8db50",
                ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                Purpose = "OTHER"
            };

            //Act
            HttpResponseMessage response = await sender.PostAsync(address, item);

            //Assert
            Assert.True(response.StatusCode == HttpStatusCode.Created);
        }
    }
}
