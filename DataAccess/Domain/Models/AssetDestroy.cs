namespace DataAccess.Domain.Models;

public class AssetDestroy
{
    public decimal Id { get; set; }
    public decimal? AssetId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? DestroyId { get; set; }
    public decimal? DestroyDiscountId { get; set; }
    public decimal? Value { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? Qty { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}