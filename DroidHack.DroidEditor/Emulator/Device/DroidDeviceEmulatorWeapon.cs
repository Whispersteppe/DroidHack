using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorWeapon : DroidDeviceEmulator
{
    public DroidDeviceEmulatorWeapon(DroidDeviceWeapon droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class WeaponDeviceActions : DeviceActions
{
}

public class WeaponDeviceState : DeviceState
{
}
