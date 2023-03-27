namespace DataAccess.Domain.Models;

public class AccountTransactionEntry
{
    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? AccountId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string? Note { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public int? CostId { get; set; }
    public int? BranchId { get; set; }
    public string? Journal { get; set; }
    public int? JournalId { get; set; }
    public int? SubId { get; set; }
    public Guid Rowguid { get; set; }
    public int? RowId { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
    public DateTime? LstUpdate { get; set; }
}