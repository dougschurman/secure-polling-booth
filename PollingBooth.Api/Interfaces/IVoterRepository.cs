using System;
using System.Collections.Generic;
using PollingBooth.Api.Models;

namespace PollingBooth.Api.Interfaces
{
    public interface IVoterRepository
    {
        List<Voter> GetVoters();
        void CreateUser(Voter voter);
        void setSubmitted(int userId);

    }
}