namespace DataAccess.Domain.Models;

public partial class DailyPoint
{
    public long Id { get; set; }
    public long? CustId { get; set; }
    public decimal? TaskId { get; set; }
    public long? CardNumber { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? ItemCount { get; set; }
    public decimal? SumBill { get; set; }
    public long? InPoints { get; set; }
    public long? OutPoints { get; set; }
    public string? WrittenBy { get; set; }
    public int? Cpu { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
