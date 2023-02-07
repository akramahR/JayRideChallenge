using JayRide.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JayRide.Core.Interfaces
{
    public interface IQuotesClient
    {
        Task<Quote> getQuotesAsync();
    }
}
