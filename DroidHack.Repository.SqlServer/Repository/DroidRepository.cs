using DroidHack.Common.Interface;
using DroidHack.Common.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Repository.SqlServer.Repository;

public class DroidRepository :IDroidRepository
{
    DroidHackDbContext _dbContext;
    public DroidRepository(DroidHackDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task CreateByID(Guid id, Droid entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Droid> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Droid>> GetDroidsForUser(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateById(Guid id, Droid entity)
    {
        throw new NotImplementedException();
    }
}

public class DroidDeviceRepository : IDroidDeviceRepository
{
    DroidHackDbContext _dbContext;
    public DroidDeviceRepository(DroidHackDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task DeleteByID(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<DroidDevice> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Task GetDevices(DeviceSearchCriteria criteria)
    {
        throw new NotImplementedException();
    }

    public Task Update(DroidDevice device)
    {
        throw new NotImplementedException();
    }
}
