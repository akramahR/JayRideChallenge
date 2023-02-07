using JayRide.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JayRide.Core.Interfaces
{
    public interface IJayRideService
    {
        Candidate GetCandidate();
        Task<string> GetCityfromIP(string IP);
        Task<QuoteWithTotalPrice> GetPriceQuotesSortedAsync(int passengerCount);


    }
}
