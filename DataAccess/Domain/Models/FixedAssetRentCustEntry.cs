namespace DataAccess.Domain.Models;

public class FixedAssetRentCustEntry
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? CustId { get; set; }
    public string? Ship { get; set; }
    public string? Notes { get; set; }
    public int? AssetId { get; set; }
    public int? MethodId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? RentPeriod { get; set; }
    public bool? IsInsurancePerc { get; set; }
    public decimal? Insurance { get; set; }
    public decimal? TotalInsurance { get; set; }
    public decimal? Total { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public long? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? OtherInsurancesId { get; set; }
    public int? RentAccountId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public Guid Rowguid { get; set; }
}
