namespace DataAccess.Domain.Models;

public partial class InvoiceExpense
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? ArName { get; set; }
    public int? AccountId { get; set; }
    public int? CustId { get; set; }
    public bool? Active { get; set; }
    public string? Allocation { get; set; }
    public bool? IsAllItems { get; set; }
    public decimal? Value { get; set; }
    public string? Currency { get; set; }
    public string? Note { get; set; }
    public string? Taxable { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? CostPaying { get; set; }
    public int? CostId { get; set; }
    public byte? CostType { get; set; }
    public Guid Rowguid { get; set; }
}
