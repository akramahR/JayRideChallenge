using JayRide.Core.Interfaces;
using JayRide.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayRide.Core
{
    public class JayRideService : IJayRideService
    {
        private readonly ICityLocaterClient cityLocaterClient;
        private readonly IQuotesClient quotesClient; 
        public JayRideService(ICityLocaterClient cityLocater, IQuotesClient quotes)
        {
            this.cityLocaterClient = cityLocater;
            this.quotesClient = quotes;
        }

        public Candidate GetCandidate() => new Candidate("test", "test");

        public async Task<string> GetCityfromIP(string IP)
        {
            var city = await cityLocaterClient.GetCityAsync(IP);
            return city;
        }

        public async Task<QuoteWithTotalPrice> GetPriceQuotesSortedAsync(int passengerCount)
        {
            var quote = await quotesClient.getQuotesAsync();

            var res = quote.listings
                .Where(x => x.vehicleType.maxPassengers >= passengerCount)
                .Select(x => new ListingWithTotalPrice(x.name,x.pricePerPassenger, x.pricePerPassenger * passengerCount, x.vehicleType))
                .OrderBy(x => x.totalPrice).ToList();

            var quotesFinal = new QuoteWithTotalPrice(quote.from,quote.to,res);

            return quotesFinal;
        }
    }
}
