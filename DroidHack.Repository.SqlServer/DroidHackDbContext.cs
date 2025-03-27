using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DroidHack.Repository.SqlServer
{
    public class DroidHackDbContext : DbContext
    {
        public DbSet<DroidHackUser> Users { get; set; }
        public DbSet<Alliance> Alliances { get; set; }
        public DbSet<AllianceMember> AllianceMembers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Droid> Droids { get; set; }
        public DbSet<World> Worlds { get; set; }

        public DroidHackDbContext(DbContextOptions<DroidHackDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Droid).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
