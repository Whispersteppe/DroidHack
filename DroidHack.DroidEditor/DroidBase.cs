using DroidHack.Common.Model;
using DroidHack.DroidEditor.Emulator.Device;
using DroidHack.DroidEditor.Emulator.Factory;

namespace DroidHack.DroidEditor;

/// <summary>
/// the world engine piece that handles interactions between a DroidBase and the world
/// </summary>
public class DroidEmulator
{
    Droid _droidData;
    IDroid _droid;
    List<DroidDeviceEmulator> _devices;
    public DroidEmulator(Droid droidData)
    {
        //  take the droid data, build the class, install the devices
        _droidData = droidData;

        BuildDevices(droidData.DroidDevices);
        BuildDroid();

    }

    public void BuildDevices(List<DroidDevice> deviceData)
    {
        GeneralDroidDeviceEmulatorFactory factory = new GeneralDroidDeviceEmulatorFactory();

        _devices = new List<DroidDeviceEmulator>();
        foreach (var device in deviceData)
        {
            var deviceEmulator = factory.CreateEmulator(device);
            _devices.Add(deviceEmulator);
        }
    }

    public void BuildDroid()
    {

        //  compile the data in _droidData.Code
    }

    public void InitializeDroid()
    {
        //  create an instance of the droid.  do I need a DI engine in here?
    }
}


/// <summary>
/// the base class for all droids being developed
/// </summary>
public class DroidBase : IDroid
{
    public DroidBase()
    {

    }
}

/// <summary>
/// a simplistic droid that exposes all information as properties and methods to any child classes
/// </summary>
public class DroidSimple
{
}




/// <summary>
/// messages from the world and emulator back to the droid
/// </summary>
public class DeviceStatusMessage
{

}


/// <summary>
/// various interfaces that fit in various places
/// </summary>
public interface IDroid
{

}



public interface IDroidDevice
{

}


