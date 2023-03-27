namespace DataAccess.Domain.Models;

public class DailyFixedAsset
{
    public long Id { get; set; }
    public long? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public int? CustId { get; set; }
    public decimal? AssetId { get; set; }
    public string? Dealing { get; set; }
    public decimal RegNum { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Qtyin { get; set; }
    public decimal? QtyOut { get; set; }
    public decimal? Qty { get; set; }
    public decimal? QtyRentIn { get; set; }
    public decimal? QtyRentOut { get; set; }
    public decimal? Extra { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Price { get; set; }
    public decimal? NetPrice { get; set; }
    public decimal? Tax { get; set; }
    public decimal? CostPrice { get; set; }
    public decimal? AssetCostin { get; set; }
    public decimal? AssetCostOut { get; set; }
    public decimal? AssetCostTotal { get; set; }
    public decimal? TaskId { get; set; }
    public string? Note { get; set; }
    public decimal? RentId { get; set; }
    public decimal? DestroyId { get; set; }
    public decimal? DeprecateCenterIn { get; set; }
    public decimal? DeprecateCenterOut { get; set; }
    public string? Ship { get; set; }
    public string? ParentShip { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
}