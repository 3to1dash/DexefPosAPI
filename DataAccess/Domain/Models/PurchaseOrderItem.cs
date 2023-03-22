namespace DataAccess.Domain.Models;

public class PurchaseOrderItem
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Name { get; set; }
    public DateTime? DueDt { get; set; }
    public int? Status { get; set; }
    public Guid Rowguid { get; set; }
}
