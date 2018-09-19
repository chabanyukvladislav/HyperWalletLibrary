﻿using System;
using HyperWalletLibrary.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace HyperWalletLibrary.Components
{
    public class HyperWalletSender<T> : IHyperWalletSender<T> where T : IHyperWalletModel
    {
        private readonly HttpClient _client;
        private HttpResponseMessage _response;
        private HttpContent _content;

        public HyperWalletSender(string programToken, string username, SecureString password)
        {
            HttpClientHandler handler = new HttpClientHandler
            {
                Credentials = new NetworkCredential(username, password)
            };
            _client = new HttpClient(handler);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", programToken);
        }

        public async Task<HttpResponseMessage> SendAsync(string address, IHyperWalletSenderSettings<T> settings)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException("Address can not be null or empty");
            switch (settings.Type)
            {
                case HttpType.Get:
                    return await GetAsync(address);
                case HttpType.Post:
                    return await PostAsync(address, settings.Data);
                case HttpType.Put:
                    return await PutAsync(address, settings.Data);
                default:
                    throw new ArgumentNullException("IHyperWalletSenderSettings.Type can not be null");
            }
        }

        private void SerializeContent(T data)
        {
            if (data == null)
                throw new ArgumentNullException("IHyperWalletSenderSettings.Data can not be null");
            string json = "";
            json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatString = "yyyy-MM-ddTHH:mm:ss" });
            _content = new StringContent(json, Encoding.UTF8, "application/json");
        }

        public async Task<HttpResponseMessage> GetAsync(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException("Address can not be null or empty");
            _response = await _client.GetAsync(address);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            return _response;
        }

        public async Task<HttpResponseMessage> PostAsync(string address, T item)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException("Address can not be null or empty");
            SerializeContent(item);
            _response = await _client.PostAsync(address, _content);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            return _response;
        }

        public async Task<HttpResponseMessage> PutAsync(string address, T item)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException("Address can not be null or empty");
            SerializeContent(item);
            _response = await _client.PutAsync(address, _content);
            if (!_response.IsSuccessStatusCode)
                throw new HttpRequestException("Request is not success. The code of error: " + _response.StatusCode);
            return _response;
        }
    }
}
