namespace DataAccess.Domain.Models;

public class Slice
{
    public decimal Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public decimal? AbsentId { get; set; }
    public decimal? ExtraDayId { get; set; }
    public decimal? ExtraHourId { get; set; }
    public decimal? MaxSolfaId { get; set; }
    public decimal? HalfHourId { get; set; }
    public decimal? HourId { get; set; }
    public decimal? Hour2Id { get; set; }
    public decimal? DayQuartId { get; set; }
    public decimal? DayHalfId { get; set; }
    public bool? VacationRelay { get; set; }
    public DateTime? Timein { get; set; }
    public DateTime? Timeout { get; set; }
    public decimal? Timedelay { get; set; }
    public decimal? Salary { get; set; }
    public decimal? WithoutLogOutId { get; set; }
    public bool? IsDiscount { get; set; }
    public bool? HasAttendance { get; set; }
    public decimal? TimeExtra { get; set; }
    public decimal? FactoreId { get; set; }
    public decimal? DistributeId { get; set; }
    public decimal? InstallmentId { get; set; }
    public decimal? PledgeId { get; set; }
    public decimal? VacationDiscountId { get; set; }
    public decimal? ItineraryId { get; set; }
    public Guid Rowguid { get; set; }
}
