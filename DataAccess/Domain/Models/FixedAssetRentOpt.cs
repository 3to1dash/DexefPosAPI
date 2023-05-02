namespace DataAccess.Domain.Models;

public class FixedAssetRentOpt
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public int? AssetId { get; set; }
    public bool? IsInsurancePerc { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
}