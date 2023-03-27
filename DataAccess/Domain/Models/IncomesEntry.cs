namespace DataAccess.Domain.Models;

public class IncomesEntry
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public string? Num { get; set; }
    public decimal? TaskId { get; set; }
    public int? SpentId { get; set; }
    public int? AccountId { get; set; }
    public int? CostId { get; set; }
    public decimal? Amount { get; set; }
    public string? Note { get; set; }
    public bool? NeedCost { get; set; }
    public int? CustId { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public int? TaxAccountId { get; set; }
    public string? ReNum { get; set; }
    public decimal? Total { get; set; }
    public Guid Rowguid { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
    public DateTime? LstUpdate { get; set; }
}