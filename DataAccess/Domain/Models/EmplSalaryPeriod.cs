namespace DataAccess.Domain.Models;

public partial class EmplSalaryPeriod
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Status { get; set; }
    public bool? Calced { get; set; }
    public bool? Paid { get; set; }
    public decimal? CalcAmount { get; set; }
    public decimal? PaidAmount { get; set; }
    public decimal? RemainAmount { get; set; }
}
