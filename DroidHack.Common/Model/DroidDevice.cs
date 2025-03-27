namespace DroidHack.Common.Model;

public class DroidDevice
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DeviceType DeviceType { get; set; }
    public ModelPropertySet Properties { get; set; }

}
