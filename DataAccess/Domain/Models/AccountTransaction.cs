namespace DataAccess.Domain.Models;

public class AccountTransaction
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public string? Ship { get; set; }
    public int? Counts { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string? Note { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? CostId { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? PeriodId { get; set; }
    public string? WrittenBy { get; set; }
    public string? Updatedby { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
}