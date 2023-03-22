namespace DataAccess.Domain.Models;

public class Alarm
{
    public long Id { get; set; }
    public string? AccountType { get; set; }
    public int? AccountId { get; set; }
    public int? BranchId { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public int? StoreId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? AlarmAmount { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? TaskId { get; set; }
    public bool? Done { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
