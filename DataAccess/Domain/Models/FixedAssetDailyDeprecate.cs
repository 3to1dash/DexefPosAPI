namespace DataAccess.Domain.Models;

public partial class FixedAssetDailyDeprecate
{
    public int Id { get; set; }
    public int? AssetId { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public DateTime? DtUse { get; set; }
    public DateTime? DtLastCalc { get; set; }
    public DateTime? DtCalc { get; set; }
    public decimal? DepreciationRatio { get; set; }
    public decimal? StartValue { get; set; }
    public decimal? ScrapValue { get; set; }
    public decimal? Qty { get; set; }
    public decimal? DepValue { get; set; }
    public decimal? DeprecateCenterIn { get; set; }
    public decimal? DeprecateCenterOut { get; set; }
    public decimal? TaskId { get; set; }
    public long? RegNum { get; set; }
    public long? BranchId { get; set; }
    public long? ExpenseId { get; set; }
    public long? DepCenter { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Notes { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public bool? Attached { get; set; }
    public Guid Rowguid { get; set; }
}
