namespace DataAccess.Domain.Models;

public class WorkMove
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? PrevBranchId { get; set; }
    public decimal? PrevSlice { get; set; }
    public decimal? PrevDepart { get; set; }
    public decimal? PrevJob { get; set; }
    public decimal? SliceId { get; set; }
    public decimal? JobId { get; set; }
    public decimal? DepartId { get; set; }
    public decimal? BranchId { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
