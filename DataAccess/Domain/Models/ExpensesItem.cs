namespace DataAccess.Domain.Models;

public partial class ExpensesItem
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public decimal? Num { get; set; }
    public string? ArName { get; set; }
    public bool? Active { get; set; }
    public int? AccountId { get; set; }
    public int? CostId { get; set; }
    public string? Note { get; set; }
    public bool? Taxable { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public int? CostType { get; set; }
    public bool? IsAllItems { get; set; }
    public int? CalcType { get; set; }
    public string? ExpenseType { get; set; }
    public string? AllocationType { get; set; }
    public Guid Rowguid { get; set; }
}
