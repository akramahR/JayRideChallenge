using JayRide.Core.Interfaces;
using JayRide.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JayRide.Infrastructure
{
    internal class QuoteAPIClient : IQuotesClient
    {
        private readonly HttpClient _httpClient;
        public QuoteAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jayridechallengeapi.azurewebsites.net/api/");
        }
        public async Task<Quote> getQuotesAsync()
        {
            var result = await _httpClient.GetStringAsync("QuoteRequest");
            var data = JsonSerializer.Deserialize<Quote>(result);

            return data;
        }
    }
}
