namespace DataAccess.Domain.Models;

public class WorkExtraday
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Hours { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Total { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? OperatIndex { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}
