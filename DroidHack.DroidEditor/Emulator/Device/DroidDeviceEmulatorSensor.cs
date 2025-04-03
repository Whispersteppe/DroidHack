using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

public class DroidDeviceEmulatorSensor : DroidDeviceEmulator
{
    public DroidDeviceEmulatorSensor(DroidDeviceSensor droidDeviceData) : base(droidDeviceData)
    {
    }
}

public class SensorDeviceActions : DeviceActions
{
}

public class SensorDeviceState : DeviceState
{
}