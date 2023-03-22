namespace DataAccess.Domain.Models;

public class ExpensesClass
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public short? TypeIndex { get; set; }
    public bool? MustCust { get; set; }
    public bool? MustCostId { get; set; }
    public int? CostId { get; set; }
    public bool? MustTax { get; set; }
    public int? TaxId { get; set; }
    public bool? AutoNum { get; set; }
    public string? Prefix { get; set; }
    public string? Ship { get; set; }
    public bool? HasEstimate { get; set; }
    public bool? ShowRef { get; set; }
    public bool? ShowCostCenter { get; set; }
    public bool? ShowTaxes { get; set; }
    public Guid Rowguid { get; set; }
}
