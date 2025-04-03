using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorRepair : DroidDeviceEmulator
{
    public DroidDeviceEmulatorRepair(DroidDeviceRepair droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class RepairDeviceActions : DeviceActions
{
}

public class RepairDeviceState : DeviceState
{
}