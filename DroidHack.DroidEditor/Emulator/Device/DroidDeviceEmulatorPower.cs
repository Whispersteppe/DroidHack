using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorPower : DroidDeviceEmulator
{
    public DroidDeviceEmulatorPower(DroidDevicePower droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class PowerDeviceActions : DeviceActions
{
}

public class PowerDeviceState : DeviceState
{
}