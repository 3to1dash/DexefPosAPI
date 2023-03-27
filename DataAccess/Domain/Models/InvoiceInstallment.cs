namespace DataAccess.Domain.Models;

public class InvoiceInstallment
{
    public int Id { get; set; }
    public int? CustId { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public int? InstallmentId { get; set; }
    public int? EarnedAccountId { get; set; }
    public int? UnEarnedAccountId { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public decimal? InvoiceRemain { get; set; }
    public decimal? InstallmentAmount { get; set; }
    public decimal? NetTotal { get; set; }
    public DateTime? FirstPaymentDt { get; set; }
    public DateTime? EndPaymentDt { get; set; }
    public int? CalcWay { get; set; }
    public decimal? PrePaid { get; set; }
    public bool? IsPerc { get; set; }
    public decimal? EndPaid { get; set; }
    public bool? IsEndPerc { get; set; }
    public int? Counts { get; set; }
    public int? Months { get; set; }
    public int? PaymentPeriod { get; set; }
    public int? PaymentDays { get; set; }
    public Guid Rowguid { get; set; }
}