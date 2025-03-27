using DroidHack.Common.Interface;
using DroidHack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Repository.SqlServer.Repository;

public class UserRepository : IUserManagerRepository
{
    DroidHackDbContext _dbContext;
    public UserRepository(DroidHackDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task CreateOrUpdate(DroidHackUser user)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<DroidHackUser> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
