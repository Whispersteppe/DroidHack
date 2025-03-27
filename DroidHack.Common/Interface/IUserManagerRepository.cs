using DroidHack.Common.Model;

namespace DroidHack.Common.Interface;

public interface IUserManagerRepository
{
    Task<DroidHackUser> GetById(Guid id);
    Task CreateOrUpdate(DroidHackUser user);
    Task Delete(Guid id);
}
