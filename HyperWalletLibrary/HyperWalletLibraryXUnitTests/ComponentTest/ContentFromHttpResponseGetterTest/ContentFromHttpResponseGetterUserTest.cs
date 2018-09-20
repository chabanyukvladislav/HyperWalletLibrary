using System.Collections.Generic;
using System.Net.Http;
using HyperWalletLibrary.Components;
using HyperWalletLibrary.Model;
using Newtonsoft.Json;
using Xunit;

namespace HyperWalletLibraryXUnitTests.ComponentTest.ContentFromHttpResponseGetterTest
{
    public class ContentFromHttpResponseGetterUserTest
    {
        [Fact]
        public async void GetAsync_ClientUserId_123()
        {
            //Arrange
            User item = new User()
            {
                ClientUserId = "123"
            };
            string json = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(json);
            HttpResponseMessage response = new HttpResponseMessage
            {
                Content = content
            };
            ContentFromHttpResponseGetter<User> getter = new ContentFromHttpResponseGetter<User>(response);

            //Act
            User data = await getter.GetAsync();

            //Assert
            Assert.True(data.ClientUserId == "123");
        }
        [Fact]
        public async void GetAsync_Response_Count_MoreThen_0()
        {
            //Arrange
            User user = new User()
            {
                ClientUserId = "123"
            };
            Response<User> item = new Response<User>()
            {
                Count = 1,
                Data = new List<User>() { user }
            };
            string json = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(json);
            HttpResponseMessage response = new HttpResponseMessage
            {
                Content = content
            };
            ContentFromHttpResponseGetter<Response<User>> getter = new ContentFromHttpResponseGetter<Response<User>>(response);

            //Act
            Response<User> data = await getter.GetAsync();

            //Assert
            Assert.True(data.Count > 0);
        }
    }
}
