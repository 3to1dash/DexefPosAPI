namespace DataAccess.Domain.Models;

public class WorkTransaction
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? Ship { get; set; }
    public decimal? BranchId { get; set; }
    public string? WorkId { get; set; }
    public decimal? Counts { get; set; }
    public decimal? Total { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}