namespace DataAccess.Domain.Models;

public class StoreAdjustmentEntry
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public bool? IsIn { get; set; }
    public string? TransCode { get; set; }
    public string? DealType { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Code { get; set; }
    public int? StoreId { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public decimal? ItemCost { get; set; }
    public decimal? CurrentQty { get; set; }
    public decimal? CurrentQty1 { get; set; }
    public decimal? CurrentQty2 { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Qty1 { get; set; }
    public decimal? Qty2 { get; set; }
    public decimal? DiffQty { get; set; }
    public decimal? DiffQty1 { get; set; }
    public decimal? DiffQty2 { get; set; }
    public string? Unite { get; set; }
    public decimal? CurrentCost { get; set; }
    public decimal? Cost { get; set; }
    public decimal? DiffCost { get; set; }
    public decimal? UniteCost { get; set; }
    public decimal? NetPrice { get; set; }
    public int? CostId { get; set; }
    public string? Currency { get; set; }
    public int? RowId { get; set; }
    public Guid Rowguid { get; set; }
    public string? TempSerial { get; set; }
    public string? Operate { get; set; }
    public int? Optkind { get; set; }
    public DateTime? ExprDt { get; set; }
    public int? BatchId { get; set; }
    public int? ColorId { get; set; }
    public int? SizeId { get; set; }
    public int? StyleId { get; set; }
}