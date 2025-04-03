using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorCommunication : DroidDeviceEmulator
{
    public DroidDeviceEmulatorCommunication(DroidDeviceCommunication droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class CommunicationDeviceActions : DeviceActions
{
}

public class CommunicationDeviceState : DeviceState
{
}