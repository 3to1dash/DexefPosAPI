namespace DataAccess.Domain.Models;

public partial class ReportsTile
{
    public int Id { get; set; }
    public string? ArName { get; set; }
    public string? ArNameDesc { get; set; }
    public bool? IsVisible { get; set; }
    public int? Tags { get; set; }
    public int? VisibleOrder { get; set; }
    public bool? IsCompany { get; set; }
    public int? Ico { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? TuName { get; set; }
    public string? RuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
}
