namespace DataAccess.Domain.Models;

public partial class DailyItemCost
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public int? CustId { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public long? KindId { get; set; }
    public long? ItemId { get; set; }
    public string? TranCode { get; set; }
    public decimal? Qty { get; set; }
    public decimal? DealingPrice { get; set; }
    public decimal? DealingQty { get; set; }
    public decimal? NetPrice { get; set; }
    public string? DealingUnite { get; set; }
    public decimal? ItemCost { get; set; }
    public long? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public string? Currency { get; set; }
    public decimal? NewCost { get; set; }
    public decimal? Bonus { get; set; }
    public int? TempInsertedRowId { get; set; }
    public decimal? Rate { get; set; }
    public int? ColorId { get; set; }
    public int? SizeId { get; set; }
    public int? StyleId { get; set; }
    public Guid Rowguid { get; set; }
}
