using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Device;

namespace DroidHack.DroidEditor.Emulator.Factory;

public interface IDroidDeviceEmulatorFactory
{
    bool CanCreateEmulator(DroidDevice deviceData);
    DroidDeviceEmulator CreateEmulator(DroidDevice deviceData);
}
