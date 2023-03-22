namespace DataAccess.Domain.Models;

public class DailyKind
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? StoreId { get; set; }
    public long? KindId { get; set; }
    public long? ItemId { get; set; }
    public int? CustId { get; set; }
    public string? Currency { get; set; }
    public string? Dealing { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? QtyOut { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? NetPrice { get; set; }
    public string? Ship { get; set; }
    public string? ParentShip { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Qty1In { get; set; }
    public decimal? Qty1Out { get; set; }
    public decimal? Qty2In { get; set; }
    public decimal? Qty2Out { get; set; }
    public DateTime? ExprDt { get; set; }
    public decimal? CostPrice { get; set; }
    public decimal? Bounes { get; set; }
    public decimal? Extra { get; set; }
    public decimal? Discount { get; set; }
    public decimal? QtyDiscount { get; set; }
    public decimal? CashDiscount { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Total { get; set; }
    public string? Serial { get; set; }
    public string? Operate { get; set; }
    public int? CostId { get; set; }
    public int? BranchId { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? PeriodId { get; set; }
    public int? Cpu { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public bool? Updated { get; set; }
    public decimal? TotalIn { get; set; }
    public decimal? TotalOut { get; set; }
    public int? RowId { get; set; }
    public decimal? TotalCost { get; set; }
    public Guid Rowguid { get; set; }
    public int? ColorId { get; set; }
    public int? SizeId { get; set; }
    public int? StyleId { get; set; }
}
