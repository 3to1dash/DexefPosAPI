namespace DataAccess.Domain.Models;

public class DailySerial
{
    public decimal Id { get; set; }
    public long? ItemId { get; set; }
    public long? KindId { get; set; }
    public string? SerialNumber { get; set; }
    public decimal? TaskId { get; set; }
    public int? CustId { get; set; }
    public decimal? Price { get; set; }
    public string? Dealing { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public string? SerialTransaction { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}