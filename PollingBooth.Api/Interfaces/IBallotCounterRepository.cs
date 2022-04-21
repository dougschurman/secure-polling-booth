using System;
using System.Collections.Generic;
using PollingBooth.Api.Models;

namespace PollingBooth.Api.Interfaces
{
    public interface IBallotCounterRepository
    {
        int CountBallots(List<Ballot> ballots);
        List<Ballot> GetBallots(List<Ballot> ballots);

    }
}