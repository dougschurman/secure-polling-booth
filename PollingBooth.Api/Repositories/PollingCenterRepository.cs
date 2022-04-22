using System;
using PollingBooth.Api.Interfaces;
using PollingBooth.Api.Data;
using PollingBooth.Api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PollingBooth.Api.Repositories
{
    public class PollingCenterRepository : IPollingCenterRepository
    {
        private readonly PollingBoothContext _ctx;

        public PollingCenterRepository(PollingBoothContext ctx)
        {
            _ctx = ctx;
        }

        public List<Ballot> GenerateBallots()
        {
            var numVoters = _ctx.Voters.Count();
            List<Ballot> ballots = new List<Ballot>();
            for(var i = 0; i<numVoters; i++){
                ballots.Add(new Ballot());
            }

            return ballots;

        }

        public List<Ballot> GetSubmitted()
        {
            var ballots = _ctx.Ballots.AsNoTracking().ToList();
            return ballots;
        }
    }
}