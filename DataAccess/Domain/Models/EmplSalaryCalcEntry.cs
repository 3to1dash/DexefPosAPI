namespace DataAccess.Domain.Models;

public class EmplSalaryCalcEntry
{
    public int Id { get; set; }
    public int? SaleryId { get; set; }
    public int? EmpId { get; set; }
    public decimal? Salary { get; set; }
    public decimal? ChangedSalary { get; set; }
    public decimal? AnnualIncrease { get; set; }
    public decimal? Insurances { get; set; }
    public decimal? Taxes { get; set; }
    public decimal? Discounts { get; set; }
    public decimal? LoanValue { get; set; }
    public decimal? Bouns { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? NetSalary { get; set; }
}
