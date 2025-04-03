using DroidHack.Repository.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace DroidHack.Testing.Repository.SqlServer;

public class BasicSQLTests : IClassFixture<DatabaseFixture>
{
    DatabaseFixture _dbFixture;

    public BasicSQLTests(DatabaseFixture dbFixture)
    {
        _dbFixture = dbFixture;
    }

    [Fact]
    public async Task DatabaseTest()
    {
        var context = _dbFixture.DbContext;

    }
}