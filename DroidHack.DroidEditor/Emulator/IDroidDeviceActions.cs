namespace DroidHack.DroidEditor.Emulator;

public interface IDroidDeviceActions
{
    IDroidDeviceState State { get; }
    void RegisterCallback(IDroidDeviceCallback callback);
}
