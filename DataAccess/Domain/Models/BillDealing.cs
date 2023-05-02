namespace DataAccess.Domain.Models;

public class BillDealing
{
    public string StoreName { get; set; } = null!;
    public decimal Id { get; set; }
    public string? BillNum { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? BillIndex { get; set; }
    public int? StoreId { get; set; }
    public string? PoNumber { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Ship { get; set; }
    public string? ShipManager { get; set; }
    public string? ShipAdress { get; set; }
    public string? ShipPhone1 { get; set; }
    public string? ShipPhone2 { get; set; }
    public DateTime? ShipDue { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public decimal? ItemCount { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalExtra { get; set; }
    public decimal? TotalPay { get; set; }
    public decimal? Remain { get; set; }
    public decimal? SumBill { get; set; }
    public string? Note { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? Attarched { get; set; }
    public decimal? Visa { get; set; }
    public decimal? Money { get; set; }
    public decimal? Bank { get; set; }
    public decimal? Pledge { get; set; }
    public bool? Printed { get; set; }
    public string? PrintedBy { get; set; }
    public int? PrintCount { get; set; }
    public bool? Reviewed { get; set; }
    public string? ReviewedBy { get; set; }
    public decimal? BillTax { get; set; }
    public decimal? BillTaxPerc { get; set; }
    public decimal? BillTaxDiscount { get; set; }
    public decimal? BillTaxDiscountPerc { get; set; }
    public bool? IsPaid { get; set; }
    public decimal? OtherPayment { get; set; }
    public decimal? ParentTaskId { get; set; }
    public int? CustId { get; set; }
    public string? Status { get; set; }
    public int? UsedPaymentIndex { get; set; }
    public int? TransId { get; set; }
    public decimal? RecievedMoney { get; set; }
    public decimal? ReturnedRemain { get; set; }
    public decimal? DonationAmount { get; set; }
    public int? PeriodId { get; set; }
    public int? ToStoreId { get; set; }
}