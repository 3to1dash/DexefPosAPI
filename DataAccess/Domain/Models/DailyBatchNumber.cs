namespace DataAccess.Domain.Models;

public partial class DailyBatchNumber
{
    public long Id { get; set; }
    public int? OperateId { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public int? CustId { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public long? KindId { get; set; }
    public long? ItemId { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? QtyOut { get; set; }
    public long? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
