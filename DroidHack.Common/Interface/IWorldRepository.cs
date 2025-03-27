using DroidHack.Common.Model;

namespace DroidHack.Common.Interface;

public interface IWorldRepository
{
    Task<World> GetById(Guid id);
    Task<Leaderboard> GetWorldLeaderBoard(Guid id, LeaderboardSearchCriteria criteria);

    Task UpdateLeaderboard(LeaderboardEntry leaderboardEntry);
    Task<List<World>> GetWorldList(WorldSearchCriteria criteria);
}
