namespace DataAccess.Domain.Models;

public partial class HrInsuranceSetting
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
    public decimal? BasicEmployee { get; set; }
    public decimal? BasicCompany { get; set; }
    public decimal? BasicTotal { get; set; }
    public decimal? BasicMaximum { get; set; }
    public decimal? ChangedEmployee { get; set; }
    public decimal? ChangedCompany { get; set; }
    public decimal? ChangedTotal { get; set; }
    public decimal? ChangedMaximum { get; set; }
    public int? AccountId { get; set; }
    public int? SalaryId { get; set; }
}
