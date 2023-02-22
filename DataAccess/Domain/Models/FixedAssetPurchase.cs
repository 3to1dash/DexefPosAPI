namespace DataAccess.Domain.Models;

public partial class FixedAssetPurchase
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public bool? IsCash { get; set; }
    public bool? IsBillDiscount { get; set; }
    public int? CustId { get; set; }
    public string? Ship { get; set; }
    public int? BillTaxId { get; set; }
    public decimal? BillTax { get; set; }
    public decimal? BillTaxPerc { get; set; }
    public int? PaymentType { get; set; }
    public int? AccountId { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalPay { get; set; }
    public decimal? TotalExtra { get; set; }
    public decimal? Remain { get; set; }
    public decimal? SumBill { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? CostId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? Note { get; set; }
    public int? Cpu { get; set; }
    public int? PeriodId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}
