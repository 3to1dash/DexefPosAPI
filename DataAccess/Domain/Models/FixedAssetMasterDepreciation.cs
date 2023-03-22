namespace DataAccess.Domain.Models;

public class FixedAssetMasterDepreciation
{
    public int Id { get; set; }
    public int? AssetId { get; set; }
    public DateTime? DtDepreciation { get; set; }
    public decimal? ScarpValue { get; set; }
    public decimal? AssetValue { get; set; }
    public decimal? DepreciationRatio { get; set; }
    public decimal? Value { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}
