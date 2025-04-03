namespace DroidHack.DroidEditor.Emulator;

public interface IDroidDeviceCallback
{
    void OnDeviceConnected();
    void OnDeviceDisconnected();
    void OnDeviceDamaged();
    void OnDeviceRepaired();
    void OnDeviceReady();
}
