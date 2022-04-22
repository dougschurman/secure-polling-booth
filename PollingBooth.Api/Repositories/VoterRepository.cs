using System;
using PollingBooth.Api.Interfaces;
using PollingBooth.Api.Data;
using PollingBooth.Api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PollingBooth.Api.Repositories
{
    public class VoterRepository : IVoterRepository
    {
        private readonly PollingBoothContext _ctx;

        public VoterRepository(PollingBoothContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateUser(Voter voter)
        {
            _ctx.Add(new Voter
            {
                Username = voter.Username,
                Name = voter.Name,
                Address = voter.Address,
                Ssn = voter.Ssn,
                Token = voter.Token,
                Password = voter.Password,
                DriverId = voter.DriverId,
                Salt = voter.Salt,
                Submitted = voter.Submitted,
                Hpassword = voter.Hpassword
            });
            _ctx.SaveChanges();
        }

        public List<Voter> GetVoters()
        {
            var voters = _ctx.Voters.AsNoTracking().ToList();
            return voters;
        }

        public void setSubmitted(int userId){
            var user = _ctx.Voters.Where(x => x.VoterId == userId).FirstOrDefault();
            user.Submitted = true;
        }
    }
}