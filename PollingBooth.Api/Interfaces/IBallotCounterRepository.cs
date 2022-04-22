using System;
using System.Collections.Generic;
using PollingBooth.Api.Models;

namespace PollingBooth.Api.Interfaces
{
    public interface IBallotCounterRepository
    {
        Dictionary<string, int> CountBallots();
        List<Ballot> GetBallots();

    }
}