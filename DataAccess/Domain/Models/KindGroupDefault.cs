namespace DataAccess.Domain.Models;

public class KindGroupDefault
{
    public decimal Id { get; set; }
    public int? GroupId { get; set; }
    public int? AccountId { get; set; }
    public int? SaleId { get; set; }
    public int? ReSaleId { get; set; }
    public int? SaleCostId { get; set; }
    public int? OperateId { get; set; }
    public int? PricingMethod { get; set; }
    public int? KindOpt { get; set; }
    public string? Address1 { get; set; }
    public int? IdentityUnite { get; set; }
    public int? VendorId { get; set; }
    public decimal? Minimum { get; set; }
    public decimal? Maximum { get; set; }
    public int? FixedSale { get; set; }
    public int? ExprPeriod { get; set; }
    public int? Taxable { get; set; }
    public decimal? Tax { get; set; }
    public int? HasZeroTax { get; set; }
    public int? PriceIncludeTax { get; set; }
    public int? Discountable { get; set; }
    public int? Isdiscountperc { get; set; }
    public decimal? Discountbuy { get; set; }
    public decimal? Discountsale { get; set; }
    public decimal? Moneyextra { get; set; }
    public int? IsExpr { get; set; }
    public int? IsOperate { get; set; }
    public int? ExprFormat { get; set; }
    public int? ExprMin { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public Guid Rowguid { get; set; }
    public int? TaxId { get; set; }
    public decimal? SaleTax { get; set; }
    public decimal? PurchaseTax { get; set; }
}