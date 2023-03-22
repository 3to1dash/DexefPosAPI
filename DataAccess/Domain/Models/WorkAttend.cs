namespace DataAccess.Domain.Models;

public class WorkAttend
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public DateTime? Dt { get; set; }
    public bool? LogIn { get; set; }
    public decimal? LoginVal { get; set; }
    public bool? LogOut { get; set; }
    public decimal? LogoutVal { get; set; }
    public DateTime? CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
    public bool? Absent { get; set; }
    public decimal? AbsentVal { get; set; }
    public bool? Discount { get; set; }
    public decimal? DiscountVal { get; set; }
    public bool? Alarm { get; set; }
    public bool? Incentive { get; set; }
    public decimal? IncentiveVal { get; set; }
    public bool? Award { get; set; }
    public decimal? AwardVal { get; set; }
    public bool? Vacation { get; set; }
    public decimal? VacationPerc { get; set; }
    public decimal? VacationDiscount { get; set; }
    public decimal? VacationIndex { get; set; }
    public bool? TimeOff { get; set; }
    public bool? Itinerary { get; set; }
    public decimal? ItineraryVal { get; set; }
    public bool? ItineraryChkIn { get; set; }
    public bool? ItineraryChkOut { get; set; }
    public bool? Personalvacation { get; set; }
    public bool? Departure { get; set; }
    public decimal? DepartureVal { get; set; }
    public decimal? WorkHours { get; set; }
    public decimal? SalesPerc { get; set; }
    public bool? IsPaid { get; set; }
    public decimal? ProductItems { get; set; }
    public decimal? Solfa { get; set; }
    public decimal? ExtraDay { get; set; }
    public decimal? ExtraHour { get; set; }
    public bool? Delay { get; set; }
    public decimal? DelayVal { get; set; }
    public Guid Rowguid { get; set; }
}
