using DroidHack.Common.Enums;

namespace DroidHack.Repository.SqlServer.DataModel;

public class DroidDevice
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Properties { get; set; }

    public Guid DroidId { get; set; }
    public Guid DeviceID { get; set; }

    public DeviceType DeviceType { get; set; }
    public Device Device { get; set; }
    public Droid Droid { get; set; }
}

