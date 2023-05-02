namespace DataAccess.Domain.Models;

public class EstimateSpentItem
{
    public decimal Id { get; set; }
    public int? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public bool? IsVal { get; set; }
    public bool? IsQty { get; set; }
    public bool? IsPerc { get; set; }
    public decimal? AccountId { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}