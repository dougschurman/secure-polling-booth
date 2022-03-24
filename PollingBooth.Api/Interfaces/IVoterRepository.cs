using System;
using System.Collections.Generic;
using PollingBooth.Api.Models;

namespace PollingBooth.Api.Interfaces
{
    public interface IVoterRepository
    {
        List<Voter> GetVoters();
        Voter GetVoterByName(string username);
        bool CreateUser(string username, string name, string address, int ssn, string token, string password, string driverId, string salt, bool Submitted);

    }
}