﻿namespace DataAccess.Domain.Models;

public partial class StorePackingEntry
{
    public int Id { get; set; }
    public int? BillIndex { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Code { get; set; }
    public int? StoreId { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public decimal? ItemCost { get; set; }
    public string? ItemShip { get; set; }
    public string? ParentShip { get; set; }
    public string? Ship { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Qty1 { get; set; }
    public decimal? Qty2 { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? PriceAfterDiscount { get; set; }
    public decimal? NetPrice { get; set; }
    public decimal? Total { get; set; }
    public decimal? NetTotal { get; set; }
    public bool? Isfree { get; set; }
    public decimal? Bounes { get; set; }
    public decimal? ExtraCostPerc { get; set; }
    public decimal? ExtraCost { get; set; }
    public decimal? BillExtra { get; set; }
    public bool? Isdiscountperc { get; set; }
    public decimal? DiscountPerc { get; set; }
    public decimal? Discount { get; set; }
    public bool? Discountable { get; set; }
    public decimal? DiscountCashPerc { get; set; }
    public decimal? DiscountCash { get; set; }
    public decimal? DiscountTrade { get; set; }
    public decimal? DiscountGroup { get; set; }
    public int? TaxId { get; set; }
    public int? Taxable { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public int? IsDat { get; set; }
    public decimal? Datperc { get; set; }
    public decimal? Dat { get; set; }
    public string? Operate { get; set; }
    public DateTime? ExprDt { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalExtra { get; set; }
    public decimal? SalePrice { get; set; }
    public string? TempSerial { get; set; }
    public decimal? Quota { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? Custid { get; set; }
    public decimal? TotalQty { get; set; }
    public int? BranchId { get; set; }
    public bool? IsPaid { get; set; }
    public decimal? DisountBounesPerc { get; set; }
    public decimal? DisountBounes { get; set; }
    public int? CostId { get; set; }
    public decimal? UniteQty { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public string? DiscountPormotionEquation { get; set; }
    public decimal? DiscountPormotion { get; set; }
    public string? ExtraPormotionEquation { get; set; }
    public decimal? ExtraPormotion { get; set; }
    public decimal? ToStoreId { get; set; }
    public DateTime? DtImport { get; set; }
    public int? RepId { get; set; }
    public bool? RepDone { get; set; }
    public decimal? RepTaskId { get; set; }
    public int? VendorId { get; set; }
    public int? RepVendorSliceId { get; set; }
    public decimal? RepVendTask { get; set; }
    public bool? RepVendorDone { get; set; }
    public decimal? ItemPoints { get; set; }
    public decimal? RewardPoints { get; set; }
    public int? AccountId { get; set; }
    public decimal? DiscountAfterTax { get; set; }
    public int? DattaxId { get; set; }
    public bool? PriceIncludeTax { get; set; }
    public int? RowId { get; set; }
    public decimal? ChargeDiscount { get; set; }
    public decimal? ChargeDiscountPerc { get; set; }
    public Guid Rowguid { get; set; }
    public bool? HasInsurance { get; set; }
    public decimal? InsuranceDiscount { get; set; }
    public decimal? InsurancePerc { get; set; }
    public decimal? FreeDiscount { get; set; }
    public int? ColorId { get; set; }
    public int? SizeId { get; set; }
    public int? StyleId { get; set; }
    public bool? Updated { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public int? BatchId { get; set; }
    public int? StatusId { get; set; }
    public string? Status { get; set; }
}