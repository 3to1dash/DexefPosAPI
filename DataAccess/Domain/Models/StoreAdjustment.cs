namespace DataAccess.Domain.Models;

public partial class StoreAdjustment
{
    public decimal Id { get; set; }
    public bool? IsCredit { get; set; }
    public string? Prefix { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? StoreId { get; set; }
    public string? Ship { get; set; }
    public decimal? ItemCount { get; set; }
    public decimal? Total { get; set; }
    public int? AccountId { get; set; }
    public string? Note { get; set; }
    public int? Cpu { get; set; }
    public int? PeriodId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? Printed { get; set; }
    public string? PrintedBy { get; set; }
    public int? PrintCount { get; set; }
    public bool? Reviewed { get; set; }
    public string? ReviewedBy { get; set; }
    public decimal? ParentTaskId { get; set; }
    public bool? Updated { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public Guid Rowguid { get; set; }
}
