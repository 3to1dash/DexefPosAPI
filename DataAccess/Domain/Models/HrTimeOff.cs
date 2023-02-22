namespace DataAccess.Domain.Models;

public partial class HrTimeOff
{
    public decimal Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Active { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? TimeOffType { get; set; }
    public int? TimeOffId { get; set; }
    public decimal? Maximum { get; set; }
    public decimal? Minimum { get; set; }
    public decimal? Period { get; set; }
    public byte? Sex { get; set; }
    public string? RepeatTimeType { get; set; }
    public int? RepeatTimes { get; set; }
    public decimal? MinimumRepeatTimes { get; set; }
    public bool? SalaryDiscount { get; set; }
    public int? SalaryId { get; set; }
    public bool? DeductFromTimeoff { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
