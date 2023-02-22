namespace DataAccess.Domain.Models;

public partial class HrAttendanceSetting
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
    public int? PersonalVacation { get; set; }
    public int? PersonalVacationSeq { get; set; }
    public int? Departure { get; set; }
    public int? EarlyDeparture { get; set; }
    public int? EarlyDepartureInDay { get; set; }
    public int? ExtraWorkHours { get; set; }
    public int? ExtraWorkHoursInDay { get; set; }
    public int? ExtraDay { get; set; }
    public int? Cutout { get; set; }
}
