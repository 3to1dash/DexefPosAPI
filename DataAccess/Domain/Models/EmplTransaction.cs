namespace DataAccess.Domain.Models;

public partial class EmplTransaction
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public string? Ship { get; set; }
    public int? SalaryPeriodId { get; set; }
    public string? ItemType { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? Attach { get; set; }
}
