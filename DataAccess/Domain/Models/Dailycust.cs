namespace DataAccess.Domain.Models;

public class Dailycust
{
    public long Id { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? ExprDt { get; set; }
    public string? Num { get; set; }
    public int? AccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Value { get; set; }
    public decimal? ActualRate { get; set; }
    public decimal? Rate { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public string? Dealing { get; set; }
    public string? Ship { get; set; }
    public string? Note { get; set; }
    public decimal? BranchId { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? CostId { get; set; }
    public decimal? Cpu { get; set; }
    public decimal? PeriodId { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public bool? Updated { get; set; }
    public bool? HasBill { get; set; }
    public decimal? OpenBalance { get; set; }
    public decimal? InvoiceTotal { get; set; }
    public decimal? InvoiceExtra { get; set; }
    public decimal? InvoiceDiscount { get; set; }
    public decimal? InvoiceSum { get; set; }
    public decimal? InvoiceRemain { get; set; }
    public decimal? InvoicePaid { get; set; }
    public decimal? AgingPaid { get; set; }
    public decimal? RemainAfterAging { get; set; }
    public decimal? Discount { get; set; }
    public decimal? QtyDiscount { get; set; }
    public decimal? CashDiscount { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public int? TermsId { get; set; }
    public int? TermsState { get; set; }
    public decimal? TermsPerc { get; set; }
    public decimal? Deleteddebit { get; set; }
    public decimal? DeletedCredit { get; set; }
    public decimal? DeletedLocalDebit { get; set; }
    public decimal? DeletedLocalCredit { get; set; }
    public Guid Rowguid { get; set; }
}
