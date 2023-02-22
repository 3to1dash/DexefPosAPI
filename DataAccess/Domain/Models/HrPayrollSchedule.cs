namespace DataAccess.Domain.Models;

public partial class HrPayrollSchedule
{
    public int Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Writtenby { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public string? ScheduleType { get; set; }
    public int? Days { get; set; }
    public DateTime? StartDt { get; set; }
    public DateTime? EndDt { get; set; }
    public int? DiffDays { get; set; }
}
