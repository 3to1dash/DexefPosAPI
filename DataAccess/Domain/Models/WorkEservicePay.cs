namespace DataAccess.Domain.Models;

public partial class WorkEservicePay
{
    public decimal Id { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? WorkId { get; set; }
    public int? ServiceId { get; set; }
    public int? CostId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? PercCo { get; set; }
    public decimal? PercWork { get; set; }
    public byte? PayId { get; set; }
    public int? AccountId { get; set; }
    public decimal? PaidWork { get; set; }
    public int? PaidWorkId { get; set; }
    public decimal? PaidCo { get; set; }
    public int? PaidCoId { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public byte? PayTime { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}
