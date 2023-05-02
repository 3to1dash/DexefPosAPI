namespace DataAccess.Domain.Models;

public class WorkFactoreEntry
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? Cost { get; set; }
    public decimal? Total { get; set; }
    public decimal? Qty { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? OperatIndex { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}