namespace DataAccess.Domain.Models;

public partial class ItemsRequest
{
    public long Id { get; set; }
    public decimal? MainTaskId { get; set; }
    public decimal? ParentTaskId { get; set; }
    public decimal? TaskId { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public string? BillNum { get; set; }
    public string? WrittenBy { get; set; }
    public int? ItemCount { get; set; }
    public string? Dealing { get; set; }
    public string? Status { get; set; }
    public bool? Closed { get; set; }
    public string? CloseBy { get; set; }
    public DateTime? CloseDt { get; set; }
    public string? PrevStatus { get; set; }
    public decimal? CloseTaskId { get; set; }
    public int? TargetBranchId { get; set; }
    public int? TargetStoreId { get; set; }
    public string? Ship { get; set; }
    public DateTime? LastTrans { get; set; }
    public int? TableId { get; set; }
    public int? TableNum { get; set; }
    public int? RepId { get; set; }
    public Guid Rowguid { get; set; }
}
