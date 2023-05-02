namespace DataAccess.Domain.Models;

public class StoreSendOrder
{
    public decimal Id { get; set; }
    public string? Prefix { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? BillIndex { get; set; }
    public int? StoreId { get; set; }
    public int? CustId { get; set; }
    public int? CostId { get; set; }
    public int? IsCash { get; set; }
    public string? PoNumber { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? BillTaxId { get; set; }
    public decimal? BillTax { get; set; }
    public decimal? BillTaxPerc { get; set; }
    public int? BillTaxDiscountId { get; set; }
    public decimal? BillTaxDiscount { get; set; }
    public decimal? BillTaxDiscountPerc { get; set; }
    public decimal? TaxExtraPerc { get; set; }
    public decimal? BillExtraCost { get; set; }
    public string? Ship { get; set; }
    public string? ShipManager { get; set; }
    public string? ShipAdress { get; set; }
    public string? ShipPhone1 { get; set; }
    public string? ShipPhone2 { get; set; }
    public string? ShipVia { get; set; }
    public int? ShipTerms { get; set; }
    public DateTime? ShipDue { get; set; }
    public int? RepId { get; set; }
    public bool? RepDone { get; set; }
    public decimal? RepTaskId { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public decimal? BillChecks { get; set; }
    public decimal? BillInstallment { get; set; }
    public decimal? BillDat { get; set; }
    public decimal? ItemCount { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalExtra { get; set; }
    public decimal? TotalPay { get; set; }
    public decimal? Remain { get; set; }
    public decimal? SumBill { get; set; }
    public decimal? CashDiscount { get; set; }
    public int? CashDiscountId { get; set; }
    public decimal? CashDiscountPerc { get; set; }
    public int? CashDiscountState { get; set; }
    public decimal? QtyDiscount { get; set; }
    public int? QtyDiscountId { get; set; }
    public int? Accountid { get; set; }
    public decimal? OtherPayment { get; set; }
    public int? UsedPaymentIndex { get; set; }
    public int? IsBillDiscountPerc { get; set; }
    public decimal? BillDiscountPerc { get; set; }
    public decimal? BillDiscount { get; set; }
    public decimal? ItemExtraCost { get; set; }
    public string? Note { get; set; }
    public bool? IsPaid { get; set; }
    public int? Cpu { get; set; }
    public int? PeriodId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? Attarched { get; set; }
    public int? StyleId { get; set; }
    public bool? Printed { get; set; }
    public string? PrintedBy { get; set; }
    public int? PrintCount { get; set; }
    public bool? Reviewed { get; set; }
    public string? ReviewedBy { get; set; }
    public decimal? ParentTaskId { get; set; }
    public decimal? Money { get; set; }
    public decimal? Visa { get; set; }
    public decimal? Bank { get; set; }
    public decimal? Pledge { get; set; }
    public decimal? Account { get; set; }
    public decimal? ReturnedRemain { get; set; }
    public decimal? RewardPoints { get; set; }
    public int? RoundId { get; set; }
    public decimal? RoundAmount { get; set; }
    public decimal? RecievedMoney { get; set; }
    public decimal? PointsDiscount { get; set; }
    public Guid Rowguid { get; set; }
    public string? Status { get; set; }
    public int? DonationId { get; set; }
    public decimal? DonationAmount { get; set; }
    public int? VisitCostId { get; set; }
    public decimal? VisitCost { get; set; }
    public int? TransId { get; set; }
    public int? CreditLetterId { get; set; }
    public int? ProductionId { get; set; }
    public int? ToBranchId { get; set; }
    public int? ToStoreId { get; set; }
    public decimal? InsurancePerc { get; set; }
    public decimal? InsuranceDiscount { get; set; }
    public int? InsuranceAccountId { get; set; }
    public decimal? FreeDiscount { get; set; }
    public int? FreeAccountId { get; set; }
    public bool? Updated { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public DateTime? UploadDate { get; set; }
    public bool? Uploaded { get; set; }
    public string? Uuid { get; set; }
    public string? Uustatus { get; set; }
    public string? Dealing { get; set; }
    public int? StatusId { get; set; }
}