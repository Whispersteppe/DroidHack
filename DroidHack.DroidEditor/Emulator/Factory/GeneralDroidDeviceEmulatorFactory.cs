using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Device;

namespace DroidHack.DroidEditor.Emulator.Factory;

public class GeneralDroidDeviceEmulatorFactory : IDroidDeviceEmulatorFactory
{
    List<IDroidDeviceEmulatorFactory> _factories;

    public GeneralDroidDeviceEmulatorFactory()
    {
        _factories = new List<IDroidDeviceEmulatorFactory>()
        {
            new DroidDeviceEmulatorFactory<DroidDeviceArmor>(Common.Enums.DeviceType.Armor, x=> new DroidDeviceEmulatorArmor(x)),
            new DroidDeviceEmulatorFactory<DroidDeviceTransport>(Common.Enums.DeviceType.Transport, x=> new DroidDeviceEmulatorTransport(x)),
            new DroidDeviceEmulatorFactory<DroidDeviceShielding>(Common.Enums.DeviceType.Shielding, x=> new DroidDeviceEmulatorShielding(x)),
            new DroidDeviceEmulatorFactory<DroidDeviceCommunication>(Common.Enums.DeviceType.Communication, x=> new DroidDeviceEmulatorCommunication(x)),
            new DroidDeviceEmulatorFactory<DroidDeviceWeapon>(Common.Enums.DeviceType.Weapon, x=> new DroidDeviceEmulatorWeapon(x)),
            new DroidDeviceEmulatorFactory<DroidDeviceRepair>(Common.Enums.DeviceType.Repair, x=> new DroidDeviceEmulatorRepair(x)),
            new DroidDeviceEmulatorFactory<DroidDevicePower>(Common.Enums.DeviceType.Power, x=> new DroidDeviceEmulatorPower(x)),
            new DroidDeviceEmulatorFactory<DroidDeviceSensor>(Common.Enums.DeviceType.Sensor, x=> new DroidDeviceEmulatorSensor(x)),
        };
    }

    public bool CanCreateEmulator(DroidDevice device)
    {
        foreach (var factory in _factories)
        {
            if (factory.CanCreateEmulator(device)) return true;
        }
        return false;
    }

    public DroidDeviceEmulator CreateEmulator(DroidDevice droidDeviceData)
    {
        foreach (var factory in _factories)
        {
            if (factory.CanCreateEmulator(droidDeviceData))
            {
                return factory.CreateEmulator(droidDeviceData);
            }
        }

        throw new InvalidOperationException("Cannot create Emulator");
    }
}

public class DroidDeviceEmulatorFactory<TDroidDeviceData> : IDroidDeviceEmulatorFactory
{
    Common.Enums.DeviceType _deviceType;
    Func<TDroidDeviceData, DroidDeviceEmulator> _createFunc;
    public DroidDeviceEmulatorFactory(Common.Enums.DeviceType deviceType, Func<TDroidDeviceData, DroidDeviceEmulator> createFunc)
    {
        _deviceType = deviceType;
        _createFunc = createFunc;
    }
    public bool CanCreateEmulator(DroidDevice deviceData)
    {
        if (deviceData.DeviceType != _deviceType) return false;
        if (deviceData is not TDroidDeviceData) return false;

        return true;
    }

    public DroidDeviceEmulator CreateEmulator(DroidDevice deviceData)
    {
        if (CanCreateEmulator(deviceData))
        {
            if (deviceData is TDroidDeviceData specificDeviceData)
            {
                return _createFunc(specificDeviceData);
            }
        }

        throw new InvalidOperationException($"Cannot create device emulator from {typeof(TDroidDeviceData).Name}");
    }
}
