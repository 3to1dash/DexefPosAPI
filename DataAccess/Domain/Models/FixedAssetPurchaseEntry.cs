namespace DataAccess.Domain.Models;

public partial class FixedAssetPurchaseEntry
{
    public int Id { get; set; }
    public int? BillId { get; set; }
    public int? Code { get; set; }
    public int? AssetId { get; set; }
    public string? AssetShip { get; set; }
    public int? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? Discount { get; set; }
    public decimal? NetPrice { get; set; }
    public decimal? NetTotal { get; set; }
    public int? CostId { get; set; }
    public decimal? TotalDiscount { get; set; }
    public int? TaxId { get; set; }
    public decimal? Tax { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? BillExtra { get; set; }
    public int? RegNum { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? CustId { get; set; }
    public decimal? AssetNetCost { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}
