namespace DataAccess.Domain.Models;

public class HrAttendPolicy
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
    public bool? HasWorkShift { get; set; }
    public int? AbsentDay { get; set; }
    public int? AdditionDay { get; set; }
    public int? AdditionHour { get; set; }
    public int? DeductionHour { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
}