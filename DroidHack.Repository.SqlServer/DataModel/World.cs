namespace DroidHack.Repository.SqlServer.DataModel;

public class World
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Guid WorldOwnerID { get; set; }  
    public DroidHackUser WorldOwner { get; set; }
}
