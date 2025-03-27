namespace DroidHack.Common.Model;

public class World
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid Id { get; set; }
    public string WorldUrl { get; set; }
    public int WorldPort { get; set; }
}