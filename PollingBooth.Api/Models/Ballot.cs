using System;

namespace PollingBooth.Models
{
    public class Ballot
    {
        public int BallotId { get; set; }
        public string Candidate { get; set; }
        public string UserToken { get; set; }
    }
}