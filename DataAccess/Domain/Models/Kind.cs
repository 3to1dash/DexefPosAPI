﻿namespace DataAccess.Domain.Models;

public partial class Kind
{
    public Kind()
    {
        KindUnites = new HashSet<KindUnite>();
    }

    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? ParentId { get; set; }
    public int? TypeIndex { get; set; }
    public int? Optkind { get; set; }
    public string? Code { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Ship { get; set; }
    public int? VendorId { get; set; }
    public int? SliceId { get; set; }
    public int? AccountId { get; set; }
    public int? SaleId { get; set; }
    public int? SaleCostId { get; set; }
    public int? OperatingId { get; set; }
    public int? SaleReturnId { get; set; }
    public int? CapitalId { get; set; }
    public int? Taxable { get; set; }
    public decimal? Saletax { get; set; }
    public decimal? PurchaseTax { get; set; }
    public decimal? Tax { get; set; }
    public bool? HasZeroTax { get; set; }
    public bool? PriceIncludeTax { get; set; }
    public bool? Discountable { get; set; }
    public bool? Isdiscountperc { get; set; }
    public decimal? Discountbuy { get; set; }
    public decimal? Discountsale { get; set; }
    public bool? Active { get; set; }
    public int? PricingMode { get; set; }
    public decimal? Kindindex { get; set; }
    public decimal? Moneyextra { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public decimal? Serialcount { get; set; }
    public decimal? GuaranteePeriod { get; set; }
    public bool? IsExp { get; set; }
    public int? IdentityUnite { get; set; }
    public int? Size { get; set; }
    public int? Color { get; set; }
    public bool? HasEquation { get; set; }
    public int? ComId { get; set; }
    public bool? IsFreez { get; set; }
    public bool? CanReturn { get; set; }
    public int? ScId { get; set; }
    public int? UsageId { get; set; }
    public bool? IsOperate { get; set; }
    public int? ExprFormat { get; set; }
    public int? ExprMin { get; set; }
    public int? ForeColor { get; set; }
    public bool? HideFromTouch { get; set; }
    public decimal? RewardPoint { get; set; }
    public bool? RewardCanReplace { get; set; }
    public int? RewardReplacePoint { get; set; }
    public bool? Attach { get; set; }
    public int? VisibleOrder { get; set; }
    public int? TaxId { get; set; }
    public Guid Rowguid { get; set; }
    public string? Gstype { get; set; }
    public int? DatTaxable { get; set; }
    public int? DatId { get; set; }
    public decimal? DatPerc { get; set; }
    public string? Barcode { get; set; }
    public string? Gpccode { get; set; }
    public decimal? FixedCost { get; set; }
    public DateTime? ActiveFrom { get; set; }
    public bool? IsPrescription { get; set; }

    public virtual ICollection<KindUnite> KindUnites { get; set; }
}