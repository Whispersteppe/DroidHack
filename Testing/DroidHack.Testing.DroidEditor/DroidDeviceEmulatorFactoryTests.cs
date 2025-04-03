using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator;
using DroidHack.DroidEditor.Emulator.Device;
using DroidHack.DroidEditor.Emulator.Factory;
using FluentAssertions;

namespace DroidHack.Testing.DroidEditor;

public class DroidDeviceEmulatorFactoryTests
{
    [Fact]
    public void Factort_Fails_IfDeviceTypeMismatch()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceArmor>(Common.Enums.DeviceType.Transport, x => new DroidDeviceEmulatorArmor(x));

        var deviceData = new DroidDeviceArmor()
        {
            DeviceType = Common.Enums.DeviceType.Armor,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var act = () => armorFactory.CreateEmulator(deviceData);

        act.Should().Throw<InvalidOperationException>();
    }

    [Fact]
    public void Factort_Fails_IfDataTypeMismatch()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceArmor>(Common.Enums.DeviceType.Armor, x => new DroidDeviceEmulatorArmor(x));

        var deviceData = new DroidDeviceTransport()
        {
            DeviceType = Common.Enums.DeviceType.Armor,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var act = () => armorFactory.CreateEmulator(deviceData);

        act.Should().Throw<InvalidOperationException>();
    }

    [Fact]
    public void ArmorFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceArmor>(Common.Enums.DeviceType.Armor, x => new DroidDeviceEmulatorArmor(x));

        var deviceData = new DroidDeviceArmor()
        {
            DeviceType = Common.Enums.DeviceType.Armor,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void ShieldingFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceShielding>(Common.Enums.DeviceType.Shielding, x => new DroidDeviceEmulatorShielding(x));

        var deviceData = new DroidDeviceShielding()
        {
            DeviceType = Common.Enums.DeviceType.Shielding,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void TransportFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceTransport>(Common.Enums.DeviceType.Transport, x => new DroidDeviceEmulatorTransport(x));

        var deviceData = new DroidDeviceTransport()
        {
            DeviceType = Common.Enums.DeviceType.Transport,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void SensorFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceSensor>(Common.Enums.DeviceType.Sensor, x => new DroidDeviceEmulatorSensor(x));

        var deviceData = new DroidDeviceSensor()
        {
            DeviceType = Common.Enums.DeviceType.Sensor,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void RepairFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceRepair>(Common.Enums.DeviceType.Repair, x => new DroidDeviceEmulatorRepair(x));

        var deviceData = new DroidDeviceRepair()
        {
            DeviceType = Common.Enums.DeviceType.Repair,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void PowerFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDevicePower>(Common.Enums.DeviceType.Power, x => new DroidDeviceEmulatorPower(x));

        var deviceData = new DroidDevicePower()
        {
            DeviceType = Common.Enums.DeviceType.Power,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void WeaponFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceWeapon>(Common.Enums.DeviceType.Weapon, x => new DroidDeviceEmulatorWeapon(x));

        var deviceData = new DroidDeviceWeapon()
        {
            DeviceType = Common.Enums.DeviceType.Weapon,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Fact]
    public void CommunicationFactory_Succeeds()
    {
        var armorFactory = new DroidDeviceEmulatorFactory<DroidDeviceCommunication>(Common.Enums.DeviceType.Communication, x => new DroidDeviceEmulatorCommunication(x));

        var deviceData = new DroidDeviceCommunication()
        {
            DeviceType = Common.Enums.DeviceType.Communication,
            Description = "armor",
            Id = Guid.NewGuid(),
            Name = "my armor",
            Properties = new ModelPropertySet()
        };

        var armorItem = armorFactory.CreateEmulator(deviceData);

        armorItem.Should().NotBeNull();
    }

    [Theory]
    [InlineData(Common.Enums.DeviceType.Communication, typeof(DroidDeviceCommunication))]
    [InlineData(Common.Enums.DeviceType.Transport, typeof(DroidDeviceTransport))]
    [InlineData(Common.Enums.DeviceType.Repair, typeof(DroidDeviceRepair))]
    [InlineData(Common.Enums.DeviceType.Power, typeof(DroidDevicePower))]
    [InlineData(Common.Enums.DeviceType.Sensor, typeof(DroidDeviceSensor))]
    [InlineData(Common.Enums.DeviceType.Weapon, typeof(DroidDeviceWeapon))]
    [InlineData(Common.Enums.DeviceType.Shielding, typeof(DroidDeviceShielding))]
    [InlineData(Common.Enums.DeviceType.Armor, typeof(DroidDeviceArmor))]
    public void GenericFaFactory_Succeeds(Common.Enums.DeviceType deviceType, Type deviceDataType)
    {
        var factory = new GeneralDroidDeviceEmulatorFactory();
        var callbackClass = new DeviceCallbackTest()
        {

        };

        var data = (DroidDevice)deviceDataType.Assembly.CreateInstance(deviceDataType.FullName);
        data.DeviceType = deviceType;

        var deviceEmulator = factory.CreateEmulator(data);

        deviceEmulator.RegisterDeviceCallback(callbackClass);

        deviceEmulator.Should().NotBeNull();

    }

    internal class DeviceCallbackTest : IDroidDeviceCallback
    {
        public void OnDeviceConnected()
        {
        }

        public void OnDeviceDamaged()
        {
        }

        public void OnDeviceDisconnected()
        {
        }

        public void OnDeviceReady()
        {
        }

        public void OnDeviceRepaired()
        {
        }
    }
}