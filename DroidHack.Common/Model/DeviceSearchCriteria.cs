namespace DroidHack.Common.Model;

public interface DeviceSearchCriteria
{
    public string? Name { get; set; }
    public Guid? Id { get; set; }
    public DeviceType? DeviceType { get; set; }
}
