using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorTransport : DroidDeviceEmulator
{
    public DroidDeviceEmulatorTransport(DroidDeviceTransport droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class TransportDeviceActions : DeviceActions
{
}

public class TransportDeviceState : DeviceState
{
}