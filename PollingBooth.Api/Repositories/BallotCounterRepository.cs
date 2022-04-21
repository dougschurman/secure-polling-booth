using System;
using PollingBooth.Api.Interfaces;
using PollingBooth.Api.Data;
using PollingBooth.Api.Models;
using System.Collections.Generic;

namespace PollingBooth.Api.Repositories
{
    public class BallotCounterRepository : IBallotCounterRepository
    {
        private readonly PollingBoothContext _ctx;

        public BallotCounterRepository(PollingBoothContext ctx)
        {
            _ctx = ctx;
        }

        public int CountBallots(List<Ballot> ballots)
        {
            throw new NotImplementedException();
        }

        public List<Ballot> GetBallots(List<Ballot> ballots)
        {
            throw new NotImplementedException();
        }
    }
}