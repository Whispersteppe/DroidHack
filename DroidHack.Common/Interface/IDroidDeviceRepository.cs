using DroidHack.Common.Model;

namespace DroidHack.Common.Interface;

public interface IDroidDeviceRepository
{
    Task<DroidDevice> GetById(string id);
    Task GetDevices(DeviceSearchCriteria criteria);
    Task DeleteByID(Guid id);
    Task Update(DroidDevice device);
}
