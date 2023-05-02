namespace DataAccess.Domain.Models;

public class DailyEservice
{
    public decimal Id { get; set; }
    public int? WorkId { get; set; }
    public int? ServiceId { get; set; }
    public int? CostId { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public string? Dealing { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public byte? PayTime { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public Guid Rowguid { get; set; }
}