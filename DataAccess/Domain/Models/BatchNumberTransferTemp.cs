namespace DataAccess.Domain.Models;

public class BatchNumberTransferTemp
{
    public int Id { get; set; }
    public int? RowId { get; set; }
    public decimal? TaskId { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public int? StoreId { get; set; }
    public int? OperateId { get; set; }
    public DateTime? ExprDt { get; set; }
    public string? Operate { get; set; }
    public decimal? Qty { get; set; }
    public int? ToItemId { get; set; }
    public int? ToOperateId { get; set; }
    public Guid Rowguid { get; set; }
}