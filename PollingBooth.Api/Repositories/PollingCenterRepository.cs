using System;
using PollingBooth.Api.Interfaces;
using PollingBooth.Api.Data;
using PollingBooth.Api.Models;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public List<Ballot> GetSubmitted()
        {
            throw new NotImplementedException();
        }

        public bool ReleaseBallots()
        {
            throw new NotImplementedException();
        }
    }
}