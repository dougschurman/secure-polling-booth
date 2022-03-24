using System;

namespace PollingBooth.Api.Models
{
    public class PollingCenter
    {
        public Ballot[] ValidBallots { get; set; }
        public Candidate[] Candidates { get; set; }
    }
}