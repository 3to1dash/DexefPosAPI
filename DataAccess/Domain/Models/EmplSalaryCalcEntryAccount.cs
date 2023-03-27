namespace DataAccess.Domain.Models;

public class EmplSalaryCalcEntryAccount
{
    public int Id { get; set; }
    public int? SaleryId { get; set; }
    public bool? Isdebit { get; set; }
    public int? EmpId { get; set; }
    public string? Dealing { get; set; }
    public int? AccountId { get; set; }
    public decimal? Total { get; set; }
}