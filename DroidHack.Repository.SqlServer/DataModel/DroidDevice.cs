namespace DroidHack.Repository.SqlServer.DataModel;

public class DroidDevice
{
    public Guid Id { get; set; }
    public Droid Droid { get; set; }
    public Device Device { get; set; }
    public Guid DeviceID { get; set; }
    public Guid DroidId { get; set; }
}
