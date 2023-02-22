namespace DataAccess.Domain.Models;

public partial class GetCashPaid
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public int? CustId { get; set; }
    public byte? CustType { get; set; }
    public decimal? Value { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Discount { get; set; }
    public decimal? CashDiscount { get; set; }
    public decimal? Total { get; set; }
    public byte? PaymentIndex { get; set; }
    public int? CapitalId { get; set; }
    public int? DiscountId { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public int? CostId { get; set; }
    public string? ReNum { get; set; }
    public string? Note { get; set; }
    public int? BranchId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public bool? Attached { get; set; }
    public string? Name { get; set; }
    public string? TargetPayment { get; set; }
    public decimal? CashPayment { get; set; }
    public decimal? BankPayment { get; set; }
    public decimal? VisaPayment { get; set; }
    public decimal? PledgePayment { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
}
