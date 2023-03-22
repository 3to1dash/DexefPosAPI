namespace DataAccess.Domain.Models;

public class EmplLoanEntry
{
    public int Id { get; set; }
    public int? LoanId { get; set; }
    public int? SalaryPeriodId { get; set; }
    public decimal? Amount { get; set; }
}
