using System;
using PollingBooth.Api.Interfaces;
using PollingBooth.Api.Data;
using PollingBooth.Api.Models;
using System.Collections.Generic;

namespace PollingBooth.Api.Repositories
{
    public class VoterRepository : IVoterRepository
    {
        private readonly PollingBoothContext _ctx;

        public VoterRepository(PollingBoothContext ctx)
        {
            _ctx = ctx;
        }

        public bool CreateUser(string username, string name, string address, int ssn, string token, string password, string driverId, string salt, bool Submitted)
        {
            throw new NotImplementedException();
        }

        public Voter GetVoterByName(string username)
        {
            throw new NotImplementedException();
        }

        public List<Voter> GetVoters()
        {
            throw new NotImplementedException();
        }
    }
}