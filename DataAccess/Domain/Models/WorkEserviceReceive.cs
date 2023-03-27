namespace DataAccess.Domain.Models;

public class WorkEserviceReceive
{
    public decimal Id { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? WorkId { get; set; }
    public int? ServiceId { get; set; }
    public int? CostId { get; set; }
    public decimal? Amount { get; set; }
    public byte? PayId { get; set; }
    public int? PaidWorkId { get; set; }
    public int? AccountId { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
}