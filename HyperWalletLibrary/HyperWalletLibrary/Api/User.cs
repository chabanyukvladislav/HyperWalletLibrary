using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;

namespace HyperWalletLibrary.Api
{
    public static class User
    {
        private const string ADDRESS = @"https://api.sandbox.hyperwallet.com/rest/v3/users";

        public static async Task<IEnumerable<Model.User>> GetAsync()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            HttpResponseMessage response = await httpClient.GetAsync(new Uri(ADDRESS + "/username=restapiuser@15472201613&&password=Ke002308!!"));
            string content = await response.Content.ReadAsStringAsync();
            return JsonToEnumerableOfUserConverter.Convert(content);
        }

        public static async Task<Model.User> GetAsync(string token)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            HttpResponseMessage response = await httpClient.GetAsync(new Uri(ADDRESS + "/" + token + "/username=restapiuser@15472201613&&password=Ke002308!!"));
            string content = await response.Content.ReadAsStringAsync();
            return JsonToUserConverter.Convert(content);
        }
    }
}
