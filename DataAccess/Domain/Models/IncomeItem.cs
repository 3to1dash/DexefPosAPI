namespace DataAccess.Domain.Models;

public class IncomeItem
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public decimal? Num { get; set; }
    public string? ArName { get; set; }
    public bool? Active { get; set; }
    public int? AccountId { get; set; }
    public int? CostId { get; set; }
    public string? Note { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public int? CostType { get; set; }
    public Guid Rowguid { get; set; }
}
