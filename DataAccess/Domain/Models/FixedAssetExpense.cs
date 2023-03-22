namespace DataAccess.Domain.Models;

public class FixedAssetExpense
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public int? BillType { get; set; }
    public bool? IsCompanyExpense { get; set; }
    public int? AccountId { get; set; }
    public int? CustId { get; set; }
    public bool? Active { get; set; }
    public bool? IsValue { get; set; }
    public decimal? Value { get; set; }
    public string? Currency { get; set; }
    public string? Note { get; set; }
    public bool? Taxable { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public Guid Rowguid { get; set; }
}
