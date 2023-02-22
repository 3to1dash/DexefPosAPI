namespace DataAccess.Domain.Models;

public partial class CustInstallmentSlice
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public decimal? Profit { get; set; }
    public int? CalcWay { get; set; }
    public decimal? PrePaid { get; set; }
    public bool? IsPerc { get; set; }
    public decimal? EndPaid { get; set; }
    public bool? IsEndPerc { get; set; }
    public int? Counts { get; set; }
    public int? PaymentPeriod { get; set; }
    public int? PaymentDays { get; set; }
    public int? EarnedAccountId { get; set; }
    public int? UnEarnedAccountId { get; set; }
    public bool? CanEdit { get; set; }
    public int? Months { get; set; }
    public int? CalcTimes { get; set; }
    public decimal? ExtraCost { get; set; }
    public Guid Rowguid { get; set; }
}
