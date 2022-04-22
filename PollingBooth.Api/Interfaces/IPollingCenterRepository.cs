using System;
using System.Collections.Generic;
using PollingBooth.Api.Models;

namespace PollingBooth.Api.Interfaces
{
    public interface IPollingCenterRepository
    {
        List<Ballot> GenerateBallots();
        List<Ballot> GetSubmitted();

    }
}