namespace DataAccess.Domain.Models;

public class HrWorkTimeEntry
{
    public int Id { get; set; }
    public int? TimeId { get; set; }
    public string? TimeType { get; set; }
    public string? Name { get; set; }
    public TimeSpan? LogIn { get; set; }
    public TimeSpan LogOut { get; set; }
    public int? ExtraDay { get; set; }
    public int? LogInDelay { get; set; }
    public int? LogOutDelay { get; set; }
    public DateTime? Period { get; set; }
    public Guid Rowguid { get; set; }
}