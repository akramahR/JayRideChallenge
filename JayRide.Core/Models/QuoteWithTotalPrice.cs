using System;
using System.Collections.Generic;
using System.Text;

namespace JayRide.Core.Models
{
    public class QuoteWithTotalPrice
    {
        public QuoteWithTotalPrice(string from, string to, List<ListingWithTotalPrice> listings)
        {
            this.from = from;
            this.to = to;
            this.listings = listings;
        }

        public string from { get; set; }
        public string to { get; set; }
        public List<ListingWithTotalPrice> listings { get; set; }
    }
    public class ListingWithTotalPrice
    {
        public ListingWithTotalPrice(string name, double pricePerPassenger, double totalPrice, VehicleType vehicleType)
        {
            this.name = name;
            this.pricePerPassenger = pricePerPassenger;
            this.totalPrice = totalPrice;
            this.vehicleType = vehicleType;
        }

        public string name { get; set; }
        public double pricePerPassenger { get; set; }
        public double totalPrice { get; set; }
        public VehicleType vehicleType { get; set; }
    }
}
