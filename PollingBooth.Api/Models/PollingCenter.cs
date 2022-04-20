using System;

namespace PollingBooth.Api.Models
{
    public class PollingCenter
    {
        public int CenterId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Salt { get; set; }
        public string Hpassword { get; set; }
        public Ballot[] ValidBallots { get; set; }
    }
}