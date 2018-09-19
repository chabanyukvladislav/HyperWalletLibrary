using System;
using HyperWalletLibrary.Components;
using System.Net;
using HyperWalletLibrary.Model;
using Xunit;
using System.Net.Http;

namespace HyperWalletLibraryXUnitTests
{
    public class HyperWalletSenderTests
    {
        [Fact]
        public async void GetAsyncIsSuccessCodeReturnTrue()
        {
            //Arrange
            string username = "restapiuser@15472201613";
            string password = "Ke002308!!";
            string programToken = "prg-91b2bb2f-88c4-4a5d-b6ae-ef24b25567a3";
            NetworkCredential credential = new NetworkCredential(null, password);
            HyperWalletSender<User> sender = new HyperWalletSender<User>(programToken, username, credential.SecurePassword);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/users/";

            //Act
            HttpResponseMessage response = await sender.GetAsync(address);

            //Assert
            Assert.True(response.IsSuccessStatusCode);
        }

        /*[Fact]
        public async void PostAsyncIsSuccessCodeReturnTrue()
        {
            //Arrange
            string username = "restapiuser@15472221611";
            string password = "Ke002308!!";
            string programToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941";
            NetworkCredential credential = new NetworkCredential(null, password);
            HyperWalletSender<User> sender = new HyperWalletSender<User>(programToken, username, credential.SecurePassword);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/users/";
            User item = new User()
            {
                ProfileType = ProfileTypes.INDIVIDUAL,
                ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                ClientUserId = "t-1537364875289",
                FirstName = "John",
                LastName = "Developer",
                Email = "t-1537364875289@email.com",
                DateOfBirth = new DateTime(1991, 2, 15),
                Country = "US",
                StateProvince = "CA",
                AddressLine1 = "575 Market St",
                City = "San Francisco",
                PostalCode = "94105"
            };

            //Act
            HttpResponseMessage response = await sender.PostAsync(address, item);

            //Assert
            Assert.True(response.IsSuccessStatusCode);
        }*/

        [Fact]
        public async void PutAsyncIsSuccessCodeReturnTrue()
        {
            //Arrange
            string username = "restapiuser@15472221611";
            string password = "Ke002308!!";
            string programToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941";
            NetworkCredential credential = new NetworkCredential(null, password);
            HyperWalletSender<User> sender = new HyperWalletSender<User>(programToken, username, credential.SecurePassword);
            string address = "https://api.sandbox.hyperwallet.com/rest/v3/users/usr-01f5cfa0-5507-4d14-a9f8-df0791b5eea9/";
            User item = new User()
            {
                LastName = "Ddd",
                DateOfBirth = DateTime.Now.Date
            };

            //Act
            HttpResponseMessage response = await sender.PutAsync(address, item);

            //Assert
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
