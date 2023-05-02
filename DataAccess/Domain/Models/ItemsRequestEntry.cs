namespace DataAccess.Domain.Models;

public class ItemsRequestEntry
{
    public long Id { get; set; }
    public decimal? MainTaskId { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public long? KindId { get; set; }
    public long? ItemId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? RequestQty { get; set; }
    public decimal? InQty { get; set; }
    public decimal? OutQty { get; set; }
    public decimal? CancelQty { get; set; }
    public decimal? RemainQty { get; set; }
    public decimal? TaskId { get; set; }
    public int? TargetStoreId { get; set; }
    public string? Dealing { get; set; }
    public string? Status { get; set; }
    public Guid Rowguid { get; set; }
    public decimal? UniteQty { get; set; }
    public string? Operate { get; set; }
}