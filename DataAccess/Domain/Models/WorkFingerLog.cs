namespace DataAccess.Domain.Models;

public partial class WorkFingerLog
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public decimal? BranchId { get; set; }
    public bool? Isadd { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? OperatIndex { get; set; }
    public Guid Rowguid { get; set; }
}
