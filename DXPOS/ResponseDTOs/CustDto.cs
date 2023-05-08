namespace DXPOS.ResponseDTOs;

public class CustDto
{
    public int? Id { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public string? GrpName { get; set; }
    public string? FirstName { get; set; }
    public decimal? Balance { get; set; }
    public int? Costid { get; set; }
    public string? Currency { get; set; }
    public int? CashDiscount { get; set; }
    public int? GroupDiscount { get; set; }
    public int? Tax { get; set; }
    public string? Prefix { get; set; }
    public string? Person { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Phone3 { get; set; }
    public string? Adress { get; set; }
    public int? PriceLevel { get; set; }
    public string? Kind { get; set; }
    public bool? ShowInAll { get; set; }
    public int? TypeIndex { get; set; }
    public int? BranchID { get; set; }
    public int? DefaultCash { get; set; }
    public int? RepID { get; set; }
    public decimal? CreditLimit { get; set; }
    public bool? Taxable { get; set; }
    public decimal? TaxPerc { get; set; }
    public string? TaxName { get; set; }
}
