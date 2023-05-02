namespace DataAccess.Domain.Models;

public class PurchaseCycleEntry
{
    public long Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public string? BillNum { get; set; }
    public long? ItemId { get; set; }
    public long? KindId { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
    public decimal? ParentTaskId { get; set; }
    public string? ParentDealing { get; set; }
    public decimal? InQty { get; set; }
    public decimal? OutQty { get; set; }
    public Guid Rowguid { get; set; }
}