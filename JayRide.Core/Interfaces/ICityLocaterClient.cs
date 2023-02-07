using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JayRide.Core.Interfaces
{
    public interface ICityLocaterClient
    {
        Task<string> GetCityAsync(string IPAdress);
    }
}
