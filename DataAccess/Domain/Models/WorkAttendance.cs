namespace DataAccess.Domain.Models;

public class WorkAttendance
{
    public DateTime? Dt { get; set; }
    public string? Period { get; set; }
    public string? Dealing { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public bool? Attendance { get; set; }
    public bool? Leave { get; set; }
    public DateTime? TimeAttendance { get; set; }
    public DateTime? TimeLeave { get; set; }
    public string? Delay { get; set; }
    public string? Additional { get; set; }
    public decimal? DelayPrice { get; set; }
    public decimal? AdditionalPrice { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
