using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorShielding : DroidDeviceEmulator
{
    public DroidDeviceEmulatorShielding(DroidDeviceShielding droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class ShieldingDeviceActions : DeviceActions
{
}

public class ShieldingDeviceState : DeviceState
{
}
