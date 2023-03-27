namespace DataAccess.Domain.Models;

public class SalaryPeriod
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Value { get; set; }
    public decimal? Remain { get; set; }
    public DateTime? EndDate { get; set; }
    public int? CurMonth { get; set; }
    public decimal? RegNum { get; set; }
    public Guid Rowguid { get; set; }
}