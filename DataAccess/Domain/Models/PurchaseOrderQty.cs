namespace DataAccess.Domain.Models;

public class PurchaseOrderQty
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public decimal? TaskId { get; set; }
    public DateTime? DtImport { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? QtyOut { get; set; }
    public decimal? Qty { get; set; }
    public Guid Rowguid { get; set; }
}
