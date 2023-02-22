namespace DataAccess.Domain.Models;

public partial class StoreItemIdStyle
{
    public int Id { get; set; }
    public int? ColorId { get; set; }
    public int? SizeId { get; set; }
    public int? ItemId { get; set; }
    public int? StoreId { get; set; }
    public int? KindId { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? QtyOut { get; set; }
    public decimal? TotalVal { get; set; }
    public decimal? CostIn { get; set; }
    public decimal? CostOut { get; set; }
    public decimal? KindCost { get; set; }
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
