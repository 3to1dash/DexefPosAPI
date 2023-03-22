namespace DataAccess.Domain.Models;

public class SalariesCalc
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? MonthDt { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? Addition { get; set; }
    public decimal? Deduction { get; set; }
    public decimal? TotalSalary { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public string? Ship { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? BranchId { get; set; }
    public bool? Paid { get; set; }
    public decimal? PaidValue { get; set; }
    public decimal? Remain { get; set; }
    public bool? Closed { get; set; }
    public decimal? SalaryId { get; set; }
    public decimal? InsuranceId { get; set; }
    public decimal? TaxId { get; set; }
    public Guid Rowguid { get; set; }
}
