using PollingBooth.Api.Models;
using System;
using System.Linq;

namespace PollingBooth.Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PollingBoothContext context)
        {
            context.Database.EnsureCreated();

            // Look for any
            if (context.Voters.Any())
            {
                return;   // DB has been seeded
            }

            var voters = new Voter[]
            {
            new Voter{VoterId = 1}, new Voter{VoterId = 2}
            };
            context.SaveChanges();

            foreach (Voter e in voters)
            {
                context.Voters.Add(e);
            }
            context.SaveChanges();
        }
    }
}