namespace DataAccess.Domain.Models;

public class PurchaseServiceEntry
{
    public decimal Id { get; set; }
    public decimal? TaskId { get; set; }
    public int? CustId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? BranchId { get; set; }
    public string? Item { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
