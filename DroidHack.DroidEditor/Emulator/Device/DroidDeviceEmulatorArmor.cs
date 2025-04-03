using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorArmor : DroidDeviceEmulator
{
    public DroidDeviceEmulatorArmor(DroidDeviceArmor droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class ArmorDeviceActions : DeviceActions 
{
}

public class ArmorDeviceState : DeviceState
{
}