namespace DataAccess.Domain.Models;

public class WorkAbsentBalance
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? Personalvacation { get; set; }
    public decimal? PersonalvacationSeq { get; set; }
    public decimal? Departure { get; set; }
    public decimal? Earlydeparture { get; set; }
    public decimal? EarlydepartureInDay { get; set; }
    public decimal? Extraworkhours { get; set; }
    public decimal? ExtraworkhoursInDay { get; set; }
    public decimal? Cutout { get; set; }
    public decimal? DelayHours { get; set; }
    public decimal? PersonalvacationVal { get; set; }
    public decimal? DepartureVal { get; set; }
    public decimal? EarlydepartureVal { get; set; }
    public decimal? ExtraworkhoursVal { get; set; }
    public decimal? DelayHoursVal { get; set; }
    public decimal? Extraday { get; set; }
    public decimal? Extradayval { get; set; }
    public Guid Rowguid { get; set; }
}