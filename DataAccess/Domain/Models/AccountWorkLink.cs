namespace DataAccess.Domain.Models;

public class AccountWorkLink
{
    public decimal Id { get; set; }
    public decimal? HafezId { get; set; }
    public decimal? HourId { get; set; }
    public decimal? DayId { get; set; }
    public decimal? DistributeId { get; set; }
    public decimal? ProduceId { get; set; }
    public decimal? DiscountId { get; set; }
    public decimal? AbsentId { get; set; }
    public decimal? SolfaId { get; set; }
    public decimal? InstallmentsId { get; set; }
    public decimal? RemainId { get; set; }
    public decimal? DaySalary { get; set; }
    public decimal? HourSalary { get; set; }
    public Guid Rowguid { get; set; }
}
