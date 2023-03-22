namespace DataAccess.Domain.Models;

public class TempProcessdatum
{
    public long? Itemid { get; set; }
    public long? SellId { get; set; }
    public long? PurchaseId { get; set; }
    public decimal? OrgSellQty { get; set; }
    public decimal? SettledSellQty { get; set; }
    public decimal? RemainingQtyinPurId { get; set; }
    public decimal? TaskId { get; set; }
    public long? KindId { get; set; }
    public decimal? PurchaseTaskId { get; set; }
    public decimal? PurchaseCost { get; set; }
    public Guid Rowguid { get; set; }
}
