namespace DataAccess.Domain.Models;

public class HrContractType
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
    public bool? IsOpenPeriod { get; set; }
    public int? Months { get; set; }
    public bool? Active { get; set; }
}
