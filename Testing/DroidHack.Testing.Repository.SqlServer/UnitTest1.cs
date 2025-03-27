using DroidHack.Repository.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace DroidHack.Testing.Repository.SqlServer;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        string connectionString = "Server=localhost;Database=DroidHack_Test;Trusted_Connection=True;TrustServerCertificate=True;";
        DbContextOptionsBuilder<DroidHackDbContext> builder = new DbContextOptionsBuilder<DroidHackDbContext>();
        builder.UseSqlServer(connectionString);

        var options = builder.Options;

        DroidHackDbContext context = new DroidHackDbContext(options);
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
    }
}