namespace DataAccess.Domain.Models;

public class WJob
{
    public decimal Id { get; set; }
    public string? Job { get; set; }
    public decimal? DayAbsent { get; set; }
    public decimal? DayAward { get; set; }
    public decimal? HourAdditional { get; set; }
    public decimal? Maxsolfa { get; set; }
    public decimal? HourHafe { get; set; }
    public decimal? Hour { get; set; }
    public decimal? Hour2 { get; set; }
    public decimal? DayQuarter { get; set; }
    public decimal? DayHafe { get; set; }
    public decimal? Vacation { get; set; }
    public bool? VacationRelay { get; set; }
    public DateTime? Timein { get; set; }
    public DateTime? Timeout { get; set; }
    public decimal? Timedelay { get; set; }
    public Guid Rowguid { get; set; }
}
