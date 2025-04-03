namespace DroidHack.DroidEditor.Emulator;

public interface IDroidDeviceState
{
    public decimal Damage { get; }
    public decimal PowerDraw { get; }
    public int State { get; }
}
