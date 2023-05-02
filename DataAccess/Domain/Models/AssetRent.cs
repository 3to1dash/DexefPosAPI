namespace DataAccess.Domain.Models;

public class AssetRent
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Custid { get; set; }
    public decimal? RentId { get; set; }
    public decimal? InsuranceId { get; set; }
    public decimal? Accountid { get; set; }
    public decimal? CostId { get; set; }
    public decimal? Insurance { get; set; }
    public DateTime? Fromdt { get; set; }
    public DateTime? Todt { get; set; }
    public DateTime? Fromtime { get; set; }
    public DateTime? Totime { get; set; }
    public bool? IsInstallment { get; set; }
    public decimal? PrePaid { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? Regnum { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? Remain { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public decimal? WorkRegNum { get; set; }
    public decimal? PayType { get; set; }
    public decimal? Counts { get; set; }
    public string? Ship { get; set; }
    public Guid Rowguid { get; set; }
}