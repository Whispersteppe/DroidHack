using DroidHack.Common.Enums;

namespace DroidHack.Repository.SqlServer.DataModel;

public class AllianceMember
{
    public Guid Id { get; set; }

    public DateTime JoinDate { get; set; }
    public AllianceMemberStatus Status { get; set; }
    public Guid AllianceId { get; set; }
    public Guid MemberId { get; set; }

    public Alliance Alliance { get; set; }
    public DroidHackUser Member { get; set; }

}

