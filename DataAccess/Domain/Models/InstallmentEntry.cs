namespace DataAccess.Domain.Models;

public class InstallmentEntry
{
    public decimal Id { get; set; }
    public bool? IsCredit { get; set; }
    public int? BranchId { get; set; }
    public decimal? CustId { get; set; }
    public long? InstallmentId { get; set; }
    public int? EarnAccountId { get; set; }
    public int? UnEarnAccountId { get; set; }
    public decimal? EarnPerc { get; set; }
    public decimal? UsedProfit { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public decimal? Paid { get; set; }
    public DateTime? PaidDt { get; set; }
    public string? PaidNum { get; set; }
    public decimal? PaidTaskId { get; set; }
    public string? PaidDealing { get; set; }
    public string? PaidUser { get; set; }
    public string? Note { get; set; }
    public bool? Alarm { get; set; }
    public bool? Done { get; set; }
    public decimal? Discount { get; set; }
    public string? Emplyee { get; set; }
    public decimal? TaskId { get; set; }
    public int? Num { get; set; }
    public decimal? RowTaskId { get; set; }
    public Guid Rowguid { get; set; }

    public virtual Installment? Installment { get; set; }
}
