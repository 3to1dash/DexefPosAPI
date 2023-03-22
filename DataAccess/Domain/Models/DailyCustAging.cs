namespace DataAccess.Domain.Models;

public class DailyCustAging
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public int? CustId { get; set; }
    public bool? IsTarget { get; set; }
    public bool? IsAdjust { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? OpenBalance { get; set; }
    public decimal? NeedMoney { get; set; }
    public decimal? AgingPaid { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public DateTime? ExprDt { get; set; }
    public decimal? InvoiceTotal { get; set; }
    public decimal? InvoiceSum { get; set; }
    public decimal? InvoiceRemain { get; set; }
    public decimal? InvoicePaid { get; set; }
    public long? RegNum { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? TermsId { get; set; }
    public decimal? TermsPerc { get; set; }
    public int? TermsState { get; set; }
    public decimal? CashDiscount { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? TaxAmount { get; set; }
    public bool? UseAging { get; set; }
    public int? RepId { get; set; }
    public int? CostId { get; set; }
    public long? InstallmentId { get; set; }
    public Guid Rowguid { get; set; }
}
