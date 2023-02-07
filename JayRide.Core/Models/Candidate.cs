using System;
using System.Collections.Generic;
using System.Text;

namespace JayRide.Core.Models
{
    public class Candidate
    {
        public Candidate(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
