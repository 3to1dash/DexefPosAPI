namespace DataAccess.Domain.Models;

public class DailyChequeIn
{
    public decimal Id { get; set; }
    public int? ChequeId { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public string? BillNum { get; set; }
    public int? AccountId { get; set; }
    public string? AccountType { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public string? TargetOwner { get; set; }
    public string? Status { get; set; }
    public Guid Rowguid { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
    public DateTime? LstUpdate { get; set; }
}
