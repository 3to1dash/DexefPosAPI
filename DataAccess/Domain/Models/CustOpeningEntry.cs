namespace DataAccess.Domain.Models;

public class CustOpeningEntry
{
    public decimal Id { get; set; }
    public string? DealingId { get; set; }
    public string? Num { get; set; }
    public int? CustId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Note { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}