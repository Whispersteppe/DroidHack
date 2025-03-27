namespace DroidHack.Repository.SqlServer.DataModel;

public class Droid
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ParameterJson { get; set; }
    public string Code { get; set; }

    public Guid DroidHackId { get; set; }

    public DroidHackUser User { get; set; }
    public List<DroidDevice> DroidDevices { get; set; }

}
