namespace DataAccess.Domain.Models;

public class CashLog
{
    public long Id { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? ParentTaskId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Total { get; set; }
    public long? InstallmentId { get; set; }
    public Guid Rowguid { get; set; }
    public string? ParentDealing { get; set; }
    public string? ParentNumber { get; set; }
    public DateTime? ParentDt { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
    public DateTime? LstUpdate { get; set; }
}