namespace DataAccess.Domain.Models;

public class WorkRefusal
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Workid { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? OperatIndex { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? BranchId { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}