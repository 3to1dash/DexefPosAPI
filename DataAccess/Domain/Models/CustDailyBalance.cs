namespace DataAccess.Domain.Models;

public partial class CustDailyBalance
{
    public decimal Id { get; set; }
    public bool? ForAdjust { get; set; }
    public bool? IsTarget { get; set; }
    public string? TargetDealing { get; set; }
    public int? BranchId { get; set; }
    public string? DocumentNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public decimal? OpenBalance { get; set; }
    public decimal? NeedMoney { get; set; }
    public decimal? TotalPaid { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? InvoiceTotal { get; set; }
    public decimal? InvoiceExtra { get; set; }
    public decimal? InvoiceDiscount { get; set; }
    public decimal? InvoiceTaxes { get; set; }
    public decimal? InvoiceSum { get; set; }
    public decimal? InvoicePay { get; set; }
    public decimal? InvoiceRemain { get; set; }
    public int? BaseRegNum { get; set; }
    public decimal? BaseTaskId { get; set; }
    public DateTime? ExprDt { get; set; }
    public bool? IsPaid { get; set; }
    public bool? IsSolve { get; set; }
    public int? TermsId { get; set; }
    public int? TermsState { get; set; }
    public decimal? TermsPerc { get; set; }
    public decimal? TermsValue { get; set; }
    public decimal? UserDiscount { get; set; }
    public decimal? UserPayment { get; set; }
    public decimal? UserCashDiscount { get; set; }
    public decimal? CustomerCurPaid { get; set; }
    public decimal? SourceCurPaid { get; set; }
    public decimal? InvoiceCurPaid { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public bool? IsInstall { get; set; }
    public Guid Rowguid { get; set; }
}
