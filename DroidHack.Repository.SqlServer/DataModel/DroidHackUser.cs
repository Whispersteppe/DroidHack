namespace DroidHack.Repository.SqlServer.DataModel;

public class DroidHackUser
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public List<Droid> Droids { get; set; }
    public List<World> Worlds { get; set; }
    public List<AllianceMember> Alliances { get; set; }

}
