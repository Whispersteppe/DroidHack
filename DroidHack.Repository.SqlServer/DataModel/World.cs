namespace DroidHack.Repository.SqlServer.DataModel;

public class World
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public int Port { get; set; }
    public string Version { get; set; }

    public Guid WorldOwnerID { get; set; }  

    public DroidHackUser WorldOwner { get; set; }
}
