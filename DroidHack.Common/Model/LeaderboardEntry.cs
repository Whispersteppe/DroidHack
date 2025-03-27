namespace DroidHack.Common.Model;

public class LeaderboardEntry
{
    public Guid DroidId { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public string DroidName { get; set; }
    public DateTime EntryDate { get; set; }
    public int Score { get; set; }
    public int Ranking { get; set; }
    //  probably need something about changes and ups and downs
}
