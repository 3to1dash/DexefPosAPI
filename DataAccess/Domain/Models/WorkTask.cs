namespace DataAccess.Domain.Models;

public class WorkTask
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? WorkId { get; set; }
    public string? Ship { get; set; }
    public string? Task { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? Value { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
