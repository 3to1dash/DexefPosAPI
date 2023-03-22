namespace DataAccess.Domain.Models;

public class EmpDailyPayroll
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? EmplId { get; set; }
    public string? Dealing { get; set; }
    public int? PayrollItemId { get; set; }
    public int? SalaryPeriodId { get; set; }
    public int? AccountId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public bool? Calced { get; set; }
    public bool? Paid { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? PeriodId { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public bool? Updated { get; set; }
}
