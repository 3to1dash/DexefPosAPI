namespace DataAccess.Domain.Models;

public class AlarmEndUser
{
    public long Id { get; set; }
    public string? UserName { get; set; }
    public string? FiedName { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public long? ItemId { get; set; }
    public long? KindId { get; set; }
    public bool? IsRead { get; set; }
    public int? AccountId { get; set; }
    public string? Subject { get; set; }
    public string? Num { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
    public Guid Rowguid { get; set; }
    public int? StoreId { get; set; }
    public string? AlarmType { get; set; }
    public bool? Important { get; set; }
    public DateTime? SolveDt { get; set; }
}
