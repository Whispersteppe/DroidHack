using DroidHack.Repository.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Testing.Repository.SqlServer;

public class DatabaseFixture : IDisposable
{
    private readonly string connectionString = "Server=localhost;Database=DroidHack_Test;Trusted_Connection=True;TrustServerCertificate=True;";
    DbContextOptions<DroidHackDbContext> _options;
    public DatabaseFixture()
    {
        DbContextOptionsBuilder<DroidHackDbContext> builder = new DbContextOptionsBuilder<DroidHackDbContext>();
        builder.UseSqlServer(connectionString);

        _options = builder.Options;

        DroidHackDbContext context = new DroidHackDbContext(_options);

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }

    public DroidHackDbContext DbContext
    { 
        get
        {
            DroidHackDbContext context = new DroidHackDbContext(_options);
            return context;
        }
    }

    public void Dispose()
    {
        
    }
}
