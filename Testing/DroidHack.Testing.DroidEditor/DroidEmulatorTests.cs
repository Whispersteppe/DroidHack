using DroidHack.Common.Model;
using DroidHack.DroidEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Testing.DroidEditor;

public class DroidEmulatorTests
{
    [Fact]
    public void Constructor_ShouldSucceed()
    {
        Droid droidData = new Droid()
        {
            Code = "code",
            Description = "description",
            Id = Guid.NewGuid(),
            Name = "name",
            Properties = new ModelPropertySet(),
            UserId = Guid.NewGuid(),
            DroidDevices = new List<DroidDevice>()
            {
                new DroidDeviceArmor(){ DeviceType = Common.Enums.DeviceType.Armor }, 
                new DroidDeviceCommunication(){ DeviceType = Common.Enums.DeviceType.Communication }, 
                new DroidDevicePower() { DeviceType = Common.Enums.DeviceType.Power }, 
                new DroidDeviceRepair(){ DeviceType = Common.Enums.DeviceType.Repair },
                new DroidDeviceSensor(){ DeviceType = Common.Enums.DeviceType.Sensor },
                new DroidDeviceShielding(){ DeviceType = Common.Enums.DeviceType.Shielding },
                new DroidDeviceTransport(){ DeviceType = Common.Enums.DeviceType.Transport },
                new DroidDeviceWeapon() { DeviceType = Common.Enums.DeviceType.Weapon }
            }
        };

        DroidEmulator droidEmulator = new DroidEmulator(droidData);
    }
}
