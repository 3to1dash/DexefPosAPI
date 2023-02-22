namespace DataAccess.Domain.Models;

public partial class Estimate
{
    public int Id { get; set; }
    public string? Prefex { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? Status { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? ShipManner { get; set; }
    public int? CustId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public DateTime? DtOpen { get; set; }
    public DateTime? DtClose { get; set; }
    public decimal? PurchaseOrderValue { get; set; }
    public string? PurchaseOrder { get; set; }
    public string? ShipType { get; set; }
    public int? ShipCount { get; set; }
    public int? BankId { get; set; }
    public int? AccountId { get; set; }
    public string? VendorBank { get; set; }
    public decimal? CoverPerc { get; set; }
    public decimal? CoverValue { get; set; }
    public decimal? ComisionPerc { get; set; }
    public decimal? ComisionValue { get; set; }
    public string? ShippingWay { get; set; }
    public string? ShippingPort { get; set; }
    public DateTime? ShippingDt { get; set; }
    public string? Note { get; set; }
    public int? ItemCount { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public decimal? Amount { get; set; }
    public decimal? LocalAmount { get; set; }
}
