namespace DataAccess.Domain.Models;

public class FixedAssetRentOptEntry
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? OptId { get; set; }
    public int? BranchId { get; set; }
    public int? AssetId { get; set; }
    public int? MethodId { get; set; }
    public decimal? RentPrice { get; set; }
    public decimal? TotalRent { get; set; }
    public bool? IsInsurancePerc { get; set; }
    public decimal? Insurance { get; set; }
    public string? Notes { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
}