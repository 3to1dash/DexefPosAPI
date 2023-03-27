namespace DataAccess.Domain.Models;

public class WorkUpgrade
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? BranchId { get; set; }
    public string? Note { get; set; }
    public decimal? JobId { get; set; }
    public decimal? SliceId { get; set; }
    public decimal? DepartId { get; set; }
    public decimal? NewBranchId { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? OldSliceId { get; set; }
    public decimal? OldDepartId { get; set; }
    public decimal? OldJobId { get; set; }
    public Guid Rowguid { get; set; }
}