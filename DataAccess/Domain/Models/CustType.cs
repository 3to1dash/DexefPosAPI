namespace DataAccess.Domain.Models;

public class CustType
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public int? CustType1 { get; set; }
    public bool? Active { get; set; }
    public string? IsDebit { get; set; }
    public int? ShowIn { get; set; }
    public string? Currency { get; set; }
    public decimal? CreditLimit { get; set; }
    public int? PriceLevel { get; set; }
    public int? Area { get; set; }
    public int? CashDiscount { get; set; }
    public int? GroupDiscount { get; set; }
    public bool? Taxable { get; set; }
    public int? Tax { get; set; }
    public int? AccountId { get; set; }
    public Guid Rowguid { get; set; }
}
