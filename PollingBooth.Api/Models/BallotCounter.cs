using System;

namespace PollingBooth.Api.Models
{
    public class BallotCounter
    {
        public Ballot[][] submittedBallots{ get; set; }
        public Candidate[][] candidates{ get; set; }
    }
}