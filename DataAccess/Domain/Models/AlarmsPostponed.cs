namespace DataAccess.Domain.Models;

public class AlarmsPostponed
{
    public int Id { get; set; }
    public string? AlarmType { get; set; }
    public bool? Postponed { get; set; }
    public DateTime? PostponedDate { get; set; }
    public string? UserName { get; set; }
    public Guid Rowguid { get; set; }
}