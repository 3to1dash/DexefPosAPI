namespace DataAccess.Domain.Models;

public class WorkFactore
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Workid { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Counts { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? OperatIndex { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? Total { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}