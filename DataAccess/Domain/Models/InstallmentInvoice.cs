namespace DataAccess.Domain.Models;

public class InstallmentInvoice
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public int? SliceId { get; set; }
    public DateTime? StartDt { get; set; }
    public decimal? ProfitPerc { get; set; }
    public int? CalcWay { get; set; }
    public decimal? PrePaid { get; set; }
    public bool? IsPrePerc { get; set; }
    public decimal? EndPaid { get; set; }
    public bool? IsEndPerc { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Extra { get; set; }
    public int? Counts { get; set; }
    public int? PaymentPeriod { get; set; }
    public int? PaymentDays { get; set; }
    public int? EarnedAccountId { get; set; }
    public int? UnEarnedAccountId { get; set; }
    public int? Months { get; set; }
    public int? CalcTimes { get; set; }
    public Guid Rowguid { get; set; }
}