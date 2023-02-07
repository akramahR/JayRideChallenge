using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using JayRide.Core.Interfaces;
using JayRide.Infrastructure.Models;

namespace JayRide.Infrastructure
{
    internal class IPStackCityLocater : ICityLocaterClient
    {
        private readonly HttpClient _httpClient;
        public IPStackCityLocater(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://api.ipstack.com/");
        }
        public async Task<string> GetCityAsync(string IPAdress)
        {
            // Access key should be moved to someplace like Azure key vault or aws secret manager
            var result = await _httpClient.GetStringAsync(IPAdress + "?access_key=a7404e3920d0b39bcfdda8f848e56fe3");
            var data = JsonSerializer.Deserialize<IPStackResponse>(result);

            return data.city;
        }
    }
}
