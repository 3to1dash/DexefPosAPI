namespace DataAccess.Domain.Models;

public class FixedAssetRentCust
{
    public int Id { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public int? CustId { get; set; }
    public byte? CustType { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public string? Ship { get; set; }
    public string? Notes { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Insurance { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Total { get; set; }
    public decimal? Collected { get; set; }
    public byte? PaymentIndex { get; set; }
    public int? CapitalId { get; set; }
    public long? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public bool? Attached { get; set; }
    public Guid Rowguid { get; set; }
}
