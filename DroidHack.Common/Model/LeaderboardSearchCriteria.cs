namespace DroidHack.Common.Model;

public class LeaderboardSearchCriteria
{
    public int? FromRanking { get; set; }
    public int? ToRanking { get; set; }
    public Guid? CenterAroundUserID { get; set; }
}
