namespace DataAccess.Domain.Models;

public class CustContract
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public int? CustId { get; set; }
    public int? CustIndex { get; set; }
    public string? Ship { get; set; }
    public int? PaymentIndex { get; set; }
    public int? PaymentDays { get; set; }
    public DateTime? Dtstart { get; set; }
    public DateTime? DtEnd { get; set; }
    public DateTime? DtStartPayment { get; set; }
    public decimal? Amount { get; set; }
    public int? ItemCount { get; set; }
    public decimal? Total { get; set; }
    public int? AccountId { get; set; }
    public int? CapitalId { get; set; }
    public int? TaxId { get; set; }
    public int? CostId { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public decimal? TaskId { get; set; }
    public string? Currency { get; set; }
    public bool? IsDebit { get; set; }
    public decimal? FirstMonthAmount { get; set; }
    public bool? Taxable { get; set; }
    public decimal? TotalPaid { get; set; }
    public Guid Rowguid { get; set; }
    public byte[]? ContractFile { get; set; }
}
