using PollingBooth.Api.Models;
using Microsoft.EntityFrameworkCore;


namespace PollingBooth.Api.Data
{
    public class PollingBoothContext : DbContext
    {
        public PollingBoothContext(DbContextOptions<PollingBoothContext> options) : base(options)
        {
        }

        public DbSet<Voter> Voters { get; set; }
        public DbSet<PollingCenter> PollingCenters { get; set; }
        public DbSet<BallotCounter> BallotCounters { get; set; }
        public DbSet<Ballot> Ballots { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voter>().ToTable("Voter");
            modelBuilder.Entity<PollingCenter>().ToTable("PollingCenter");
            modelBuilder.Entity<BallotCounter>().ToTable("BallotCounter");
            modelBuilder.Entity<Ballot>().ToTable("Ballot");
        }
    }
}