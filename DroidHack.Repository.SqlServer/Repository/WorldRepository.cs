using DroidHack.Common.Interface;
using DroidHack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Repository.SqlServer.Repository;

public class WorldRepository : IWorldRepository
{
    DroidHackDbContext _dbContext;
    public WorldRepository(DroidHackDbContext dbContext) 
    { 
        _dbContext = dbContext;
    }

    public Task<World> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Leaderboard> GetWorldLeaderBoard(Guid id, LeaderboardSearchCriteria criteria)
    {
        throw new NotImplementedException();
    }

    public Task<List<World>> GetWorldList(WorldSearchCriteria criteria)
    {
        throw new NotImplementedException();
    }

    public Task UpdateLeaderboard(LeaderboardEntry leaderboardEntry)
    {
        throw new NotImplementedException();
    }
}
