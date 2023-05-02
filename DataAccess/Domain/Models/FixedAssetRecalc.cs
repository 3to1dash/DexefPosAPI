namespace DataAccess.Domain.Models;

public class FixedAssetRecalc
{
    public int Id { get; set; }
    public int? AssetId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public decimal? Value { get; set; }
    public decimal? NewValue { get; set; }
    public decimal? OldValue { get; set; }
    public decimal? DepValue { get; set; }
    public int? AssetAccountId { get; set; }
    public int? ReCalcAccountId { get; set; }
    public int? DepAccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public int? CostId { get; set; }
    public int? BranchId { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}