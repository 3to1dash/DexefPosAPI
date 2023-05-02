namespace DataAccess.Domain.Models;

public class ItemsRequestLog
{
    public long Id { get; set; }
    public decimal? DealingTaskId { get; set; }
    public DateTime? DealingDt { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public string? WrittenBy { get; set; }
    public string? Status { get; set; }
    public string? Notes { get; set; }
    public int? TargetStoreId { get; set; }
    public Guid Rowguid { get; set; }
}