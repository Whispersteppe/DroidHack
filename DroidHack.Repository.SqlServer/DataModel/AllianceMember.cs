namespace DroidHack.Repository.SqlServer.DataModel;

public class AllianceMember
{
    public Guid Id { get; set; }
    public Alliance Alliance { get; set; }
    public Guid AllianceId { get; set; }
    public DroidHackUser Member { get; set; }
    public Guid MemberId { get; set; }
}
