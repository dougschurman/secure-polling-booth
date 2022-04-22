using System;
using PollingBooth.Api.Interfaces;
using PollingBooth.Api.Data;
using PollingBooth.Api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PollingBooth.Api.Repositories
{
    public class BallotCounterRepository : IBallotCounterRepository
    {
        private readonly PollingBoothContext _ctx;

        public BallotCounterRepository(PollingBoothContext ctx)
        {
            _ctx = ctx;
        }

        public Dictionary<string, int> CountBallots()
        {
            var ballots = _ctx.Ballots.AsNoTracking().ToList();
            Dictionary<string, int> candidates = new Dictionary<string, int>();
            foreach(var ballot in ballots){
                if(candidates.ContainsKey(ballot.Candidate))
                {
                    candidates.Add(ballot.Candidate, 1);
                } else {
                    int count;
                    candidates.TryGetValue(ballot.Candidate, out count);
                    candidates[ballot.Candidate] = count + 1;
                }
            }
            return candidates;
        }

        public List<Ballot> GetBallots()
        {
            var ballots = _ctx.Ballots.AsNoTracking().ToList();
            return ballots;
        }
    }
}