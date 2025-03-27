namespace DroidHack.Repository.SqlServer.DataModel;

public class Alliance
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public List<AllianceMember> Members { get; set; }

}
