namespace DataAccess.Domain.Models;

public class PurchaseService
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public int? BranchId { get; set; }
    public int? CustId { get; set; }
    public string? CustType { get; set; }
    public string? Ship { get; set; }
    public int? IncomeId { get; set; }
    public int? TaxId { get; set; }
    public int? CostId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public byte? DiscountIndex { get; set; }
    public decimal? DiscountVal { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Tax { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public byte? PaymentIndex { get; set; }
    public int? AccountId { get; set; }
    public bool? IsPaid { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? ItemCounts { get; set; }
    public string? ReNum { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public Guid Rowguid { get; set; }
}