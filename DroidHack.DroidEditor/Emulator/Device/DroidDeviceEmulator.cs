using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor.Emulator.Device;

/// <summary>
/// the world engine piece that handles interactions between a DroidDevice and the world
/// </summary>
public class DroidDeviceEmulator
{
    IDroidDeviceCallback _deviceCallback;
    public DroidDeviceEmulator(DroidDevice droidDeviceData)
    {
    }

    public void RegisterDeviceCallback(IDroidDeviceCallback deviceCallback)
    {
        _deviceCallback = deviceCallback;
    }
}
