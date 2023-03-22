namespace DataAccess.Domain.Models;

public class WorkTaskDaily
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? TaskId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? Note { get; set; }
    public decimal? Value { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
