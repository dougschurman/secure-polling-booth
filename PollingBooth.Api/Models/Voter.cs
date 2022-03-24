using System;

namespace PollingBooth.Models
{
    public class Voter{
        public string Name{get; set;}
        public string Address{get; set;}
        public int Ssn{get; set;}
        public string Token{get; set;}
        public string Password{get; set;}
        public string DriverId{get; set;}
        public string Salt{get; set;}
        public bool Submitted{get; set;}
    }
}