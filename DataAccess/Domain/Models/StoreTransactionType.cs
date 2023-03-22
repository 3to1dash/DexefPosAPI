namespace DataAccess.Domain.Models;

public class StoreTransactionType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public string? TransactionType { get; set; }
    public bool? IsIn { get; set; }
    public int? BranchId { get; set; }
    public int? AccountId { get; set; }
    public int? CostId { get; set; }
    public int? PriceLevel { get; set; }
    public bool? ShowPrice { get; set; }
    public bool? UseJournal { get; set; }
    public bool? AutomaticApprove { get; set; }
    public Guid Rowguid { get; set; }
    public string? ApproveUsers { get; set; }
}
