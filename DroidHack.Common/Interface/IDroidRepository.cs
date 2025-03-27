using DroidHack.Common.Model;

namespace DroidHack.Common.Interface;

public interface IDroidRepository
{
    Task<Droid> GetById(Guid id);
    Task<List<Droid>> GetDroidsForUser(Guid userId);
    Task DeleteById(Guid id);
    Task UpdateById(Guid id, Droid entity);

    Task CreateByID(Guid id, Droid entity);
}
