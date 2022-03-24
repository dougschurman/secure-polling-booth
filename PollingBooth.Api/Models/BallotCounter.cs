using System;

namespace PollingBooth.Models
{
    public class BallotCounter
    {
        public Ballot[][] submittedBallots{ get; set; }
        public Candidate[][] candidates{ get; set; }
    }
}