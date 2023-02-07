using JayRide.Core.Interfaces;
using JayRide.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JayRideChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JayRideController : ControllerBase
    {

        private readonly ILogger<JayRideController> _logger;
        private readonly IJayRideService _jayRideService;

        public JayRideController(ILogger<JayRideController> logger, IJayRideService jayRideService)
        {
            _logger = logger;
            _jayRideService= jayRideService;
        }

        [HttpGet("candidate")]
        public Candidate GetCandidate()
        {
            return _jayRideService.GetCandidate();
        }

        [HttpGet("location")]
        public async Task<string> GetCity(string ip)
        {
            //if we need client ip instead of from request
            //var ip = HttpContext.Connection.RemoteIpAddress?.ToString();

            var city = await _jayRideService.GetCityfromIP(ip);
            return city;
        }

        [HttpGet("listings")]
        public async Task<QuoteWithTotalPrice> GetPriceListing(int passengerCount)
        {
            var listing = await _jayRideService.GetPriceQuotesSortedAsync(passengerCount);
            return listing;
        }
    }
}