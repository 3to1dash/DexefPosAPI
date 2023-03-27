namespace DataAccess.Domain.Models;

public class WorkInoutTemp
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public DateTime? Dt { get; set; }
    public TimeSpan? Timein { get; set; }
    public TimeSpan? Timeout { get; set; }
    public bool? Chkin { get; set; }
    public bool? Chkout { get; set; }
    public decimal? DiscountLate { get; set; }
    public decimal? ExtraHour { get; set; }
    public decimal? ExtraDay { get; set; }
    public decimal? Movebefore { get; set; }
    public decimal? Countin { get; set; }
    public decimal? Countout { get; set; }
    public bool? HasDublicate { get; set; }
    public decimal? DiscountFinger { get; set; }
    public bool? Absent { get; set; }
    public bool? TimeOff { get; set; }
    public bool? NotCome { get; set; }
    public bool? Vacation { get; set; }
    public Guid Rowguid { get; set; }
}