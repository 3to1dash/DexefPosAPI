namespace DataAccess.Domain.Models;

public partial class KindDefault
{
    public int Id { get; set; }
    public int? Optkind { get; set; }
    public string? Unite { get; set; }
    public int? CodingWay { get; set; }
    public int? ItemCalcType { get; set; }
    public bool? HasZeroTax { get; set; }
    public bool? PriceIncludeTax { get; set; }
    public decimal? LimitOrder { get; set; }
    public decimal? LimitMax { get; set; }
    public decimal? LimitFixedSale { get; set; }
    public decimal? LimitExpr { get; set; }
    public int? StIdsale { get; set; }
    public int? StIdresale { get; set; }
    public int? StIdsalecost { get; set; }
    public int? StIdstock { get; set; }
    public int? SrAccount { get; set; }
    public int? SrSale { get; set; }
    public int? SrReSale { get; set; }
    public int? LotIdsale { get; set; }
    public int? LotIdreSale { get; set; }
    public int? LotIdsaleCost { get; set; }
    public int? LotIdstock { get; set; }
    public int? FacIdsale { get; set; }
    public int? FacIdreSale { get; set; }
    public int? FacIdsaleCost { get; set; }
    public int? FacIdstock { get; set; }
    public int? FacIdoperate { get; set; }
    public int? HonIdsale { get; set; }
    public int? HonIdreSale { get; set; }
    public int? HonIdsaleCost { get; set; }
    public int? HonIdstock { get; set; }
    public string? Serial1 { get; set; }
    public string? Serial2 { get; set; }
    public string? Serial3 { get; set; }
    public int? Taxable { get; set; }
    public int? TaxId { get; set; }
    public decimal? Saletax { get; set; }
    public decimal? PurchaseTax { get; set; }
    public decimal? Tax { get; set; }
    public Guid Rowguid { get; set; }
    public int? MealIdsale { get; set; }
    public int? MealIdsaleCost { get; set; }
    public int? MealIdreSale { get; set; }
    public int? ProductIdsale { get; set; }
    public int? ProductIdsaleCost { get; set; }
    public int? ProductIdreSale { get; set; }
    public int? MealIdstock { get; set; }
    public int? MealIdoperate { get; set; }
}
