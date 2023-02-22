namespace DataAccess.Domain.Models;

public partial class AssetRecalc
{
    public decimal Id { get; set; }
    public decimal? Distroyid { get; set; }
    public decimal? Distroydiscoutid { get; set; }
    public decimal? AssetId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public decimal? Newvalue { get; set; }
    public decimal? Oldvalue { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? CostId { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
