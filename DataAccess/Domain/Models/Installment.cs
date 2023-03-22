namespace DataAccess.Domain.Models;

public class Installment
{
    public long Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? BranchId { get; set; }
    public int? EarnAccountId { get; set; }
    public int? UnEarnAccountId { get; set; }
    public decimal? EarnPerc { get; set; }
    public decimal? InstallProfit { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public bool? IsMonth { get; set; }
    public int? CustId { get; set; }
    public string? Dealing { get; set; }
    public decimal? Total { get; set; }
    public decimal? PrePaid { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public DateTime? StartDt { get; set; }
    public decimal? PayEvery { get; set; }
    public int? Counts { get; set; }
    public bool? InorOut { get; set; }
    public string? Ship { get; set; }
    public long? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? PayMonthly { get; set; }
    public decimal? PaidValue { get; set; }
    public DateTime? DtStart { get; set; }
    public decimal? LstMonth { get; set; }
    public decimal? BaseTaskId { get; set; }
    public Guid Rowguid { get; set; }

    public virtual List<InstallmentEntry> InstallmentEntries { get; set; }
}
