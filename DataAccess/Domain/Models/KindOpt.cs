namespace DataAccess.Domain.Models;

public class KindOpt
{
    public decimal Id { get; set; }
    public bool? Active { get; set; }
    public string ArName { get; set; } = null!;
    public string EnName { get; set; } = null!;
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public Guid Rowguid { get; set; }
}
