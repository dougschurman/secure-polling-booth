using System;

namespace PollingBooth.Api.Models
{
    public class BallotCounter
    {
        public int CounterId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Salt { get; set; }
        public string Hpassword { get; set; }
        public Ballot[] SubmittedBallots{ get; set; }
        public int Count { get; set; }
    }
}