namespace DataAccess.Domain.Models;

public class BillPause
{
    public int Id { get; set; }
    public int? Dafter { get; set; }
    public int? BillIndex { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Store { get; set; }
    public int? Kindid { get; set; }
    public int? ItemId { get; set; }
    public decimal? ItemCost { get; set; }
    public string? Ship { get; set; }
    public string? Class { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Lenght { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? PreTotal { get; set; }
    public bool? Isfree { get; set; }
    public decimal? Bounes { get; set; }
    public decimal? ExtraCostPerc { get; set; }
    public decimal? ExtraCost { get; set; }
    public bool? IsdiscountPerc { get; set; }
    public decimal? DiscountPerc { get; set; }
    public decimal? Discount { get; set; }
    public bool? DiscountableAcc { get; set; }
    public decimal? DiscountAccPerc { get; set; }
    public decimal? DiscountAcc { get; set; }
    public bool? Taxable { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public string? Operate { get; set; }
    public DateTime? ExprDt { get; set; }
    public decimal? Price1 { get; set; }
    public decimal? Price2 { get; set; }
    public string? TempSerial { get; set; }
    public decimal? Quota { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? RegNum { get; set; }
    public string? RowCost { get; set; }
    public decimal? Custid { get; set; }
    public decimal? TotalQty { get; set; }
    public decimal? BranchId { get; set; }
    public string? Tables { get; set; }
    public Guid Rowguid { get; set; }
}