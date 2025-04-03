using DroidHack.Common.Enums;

namespace DroidHack.Repository.SqlServer.DataModel;

public class Device
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Version { get; set; }
    public DeviceType DeviceType { get; set; }

    public List<DroidDevice> DroidDevices { get; set; }

}
