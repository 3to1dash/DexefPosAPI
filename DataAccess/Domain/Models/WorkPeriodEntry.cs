namespace DataAccess.Domain.Models;

public class WorkPeriodEntry
{
    public int Id { get; set; }
    public int? PeriodId { get; set; }
    public string? IsWork { get; set; }
    public string? Name { get; set; }
    public DateTime? LogIn { get; set; }
    public DateTime? LogOut { get; set; }
    public int? LogInDelay { get; set; }
    public int? LogOutDelay { get; set; }
    public Guid Rowguid { get; set; }
}