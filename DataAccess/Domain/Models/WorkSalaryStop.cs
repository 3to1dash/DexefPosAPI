namespace DataAccess.Domain.Models;

public partial class WorkSalaryStop
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
    public bool? SalaryOn { get; set; }
    public Guid Rowguid { get; set; }
}
