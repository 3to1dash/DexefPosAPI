namespace DataAccess.Domain.Models;

public partial class FixedAssetPremium
{
    public int Id { get; set; }
    public int? DepreciationId { get; set; }
    public int? Period { get; set; }
    public decimal? Ratio { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}
