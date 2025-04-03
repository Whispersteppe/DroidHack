namespace DroidHack.Repository.SqlServer.DataModel;

public class DroidHackUser
{
    public Guid Id { get; set; }
    public string Name { get; set; }


    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }


    public List<Droid> Droids { get; set; }
    public List<World> Worlds { get; set; }
    public List<AllianceMember> Alliances { get; set; }

}
