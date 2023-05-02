namespace DataAccess.Domain.Models;

public class SalariesCalcEntry
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? MonthDt { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? SalaryId { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? Addition { get; set; }
    public decimal? Deduction { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public bool? Paid { get; set; }
    public decimal? PaidValue { get; set; }
    public decimal? Remain { get; set; }
    public bool? IsSelect { get; set; }
    public decimal? AccountId { get; set; }
    public int? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}