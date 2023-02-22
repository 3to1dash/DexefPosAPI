namespace DataAccess.Domain.Models;

public partial class WorkDiscount
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Dealing { get; set; }
    public decimal? Type { get; set; }
    public int? Branchid { get; set; }
    public int? OperatIndex { get; set; }
    public decimal? TaskId { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}
