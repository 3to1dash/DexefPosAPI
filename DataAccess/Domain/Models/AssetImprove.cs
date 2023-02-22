namespace DataAccess.Domain.Models;

public partial class AssetImprove
{
    public decimal Id { get; set; }
    public decimal? Accountid { get; set; }
    public decimal? AssetId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Regnum { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? CostId { get; set; }
    public decimal? PayType { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
