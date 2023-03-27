namespace DataAccess.Domain.Models;

public class StoreItemId
{
    public int Id { get; set; }
    public int? StoreId { get; set; }
    public int? KindId { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? QtyOut { get; set; }
    public decimal? TotalVal { get; set; }
    public decimal? Qty1In { get; set; }
    public decimal? Qty1Out { get; set; }
    public decimal? Qty2In { get; set; }
    public decimal? Qty2Out { get; set; }
    public decimal? CostIn { get; set; }
    public decimal? CostOut { get; set; }
    public decimal? KindCost { get; set; }
    public decimal? OpenBalance { get; set; }
    public decimal? OpenCost { get; set; }
    public string? OpenUnite { get; set; }
    public decimal? OpenRegNum { get; set; }
    public decimal? OpenTaskId { get; set; }
    public decimal? OpenQty1 { get; set; }
    public decimal? OpenQty2 { get; set; }
    public string? OpenSerial { get; set; }
    public decimal? Minimum { get; set; }
    public decimal? Maximum { get; set; }
    public decimal? FixedSale { get; set; }
    public decimal? ExprDt { get; set; }
    public string? Address { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public decimal? LinPrice { get; set; }
    public DateTime? Lindt { get; set; }
    public decimal? LinQty { get; set; }
    public string? LinUnite { get; set; }
    public decimal? LoutPrice { get; set; }
    public DateTime? LoutDt { get; set; }
    public decimal? LoutQty { get; set; }
    public string? LoutUnite { get; set; }
    public decimal? OrderCounts { get; set; }
    public decimal? Quote { get; set; }
    public decimal? Ordered { get; set; }
    public decimal? Requested { get; set; }
    public decimal? Reserved { get; set; }
    public decimal? TransferAsk { get; set; }
    public decimal? TransferNeed { get; set; }
    public Guid Rowguid { get; set; }
}