namespace DataAccess.Domain.Models;

public partial class PurchaseCycle
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public string? Cycle { get; set; }
    public decimal? TaskId { get; set; }
    public bool? PurchaseQuote { get; set; }
    public bool? PurchaseOrder { get; set; }
    public bool? StoreIn { get; set; }
    public bool? Invoice { get; set; }
    public bool? Review { get; set; }
    public Guid Rowguid { get; set; }
}
