using DroidHack.Common.Enums;

namespace DroidHack.Common.Model;

public class DroidDevice
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DeviceType DeviceType { get; set; }
    public ModelPropertySet Properties { get; set; }

}

public class DroidDeviceTransport : DroidDevice
{

}

public class DroidDeviceSensor : DroidDevice
{

}

public class DroidDeviceWeapon : DroidDevice
{

}

public class DroidDeviceArmor : DroidDevice
{

}

public class DroidDeviceShielding : DroidDevice
{

}

public class DroidDeviceCommunication : DroidDevice
{

}

public class DroidDevicePower : DroidDevice
{

}

public class DroidDeviceRepair : DroidDevice
{

}