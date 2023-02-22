namespace DataAccess.Domain.Models;

public partial class AssetRentLong
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public decimal? AssetId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? RentType { get; set; }
    public decimal? RentValue { get; set; }
    public decimal? RentInsurance { get; set; }
    public decimal? PrePaid { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public DateTime? DtPay { get; set; }
    public decimal? Period { get; set; }
    public decimal? PayType { get; set; }
    public decimal? StorageId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? CostId { get; set; }
    public decimal? RentId { get; set; }
    public decimal? InsuranceId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? TotalPaid { get; set; }
    public decimal? Qty { get; set; }
    public Guid Rowguid { get; set; }
}
