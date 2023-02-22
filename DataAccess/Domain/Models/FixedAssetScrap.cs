namespace DataAccess.Domain.Models;

public partial class FixedAssetScrap
{
    public int Id { get; set; }
    public int? AssetId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public decimal? TotalQty { get; set; }
    public decimal? TotalAssetValue { get; set; }
    public decimal? TotalCalacValue { get; set; }
    public decimal? TotalDepValue { get; set; }
    public decimal? Qty { get; set; }
    public decimal? AssetValue { get; set; }
    public decimal? CalacValue { get; set; }
    public decimal? DepValue { get; set; }
    public int? AssetAccountId { get; set; }
    public int? CalcAccountId { get; set; }
    public int? DepAccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public int? CostId { get; set; }
    public string? Ship { get; set; }
    public int? BranchId { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}
