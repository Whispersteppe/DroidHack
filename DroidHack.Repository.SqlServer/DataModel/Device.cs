namespace DroidHack.Repository.SqlServer.DataModel;

public class Device
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public List<DroidDevice> DroidDevices { get; set; }

}
