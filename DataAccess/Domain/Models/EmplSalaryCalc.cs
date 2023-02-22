namespace DataAccess.Domain.Models;

public partial class EmplSalaryCalc
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? SalaryPeriodId { get; set; }
    public decimal? TotalSalary { get; set; }
    public decimal? TotalChangedSalary { get; set; }
    public decimal? TotalAnnualIncrease { get; set; }
    public decimal? TotalInsurances { get; set; }
    public decimal? TotalTaxes { get; set; }
    public decimal? TotalDiscounts { get; set; }
    public decimal? TotalLoan { get; set; }
    public decimal? TotalBouns { get; set; }
    public decimal? TotalAttendees { get; set; }
    public decimal? TotalNetSalary { get; set; }
    public int? SalariesNotPaidId { get; set; }
    public int? SalaryAccountId { get; set; }
    public int? TaxAccountId { get; set; }
    public int? InsurancesAccountId { get; set; }
    public int? RegNum { get; set; }
    public bool? Attach { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public int? SalaryGroupId { get; set; }
}
