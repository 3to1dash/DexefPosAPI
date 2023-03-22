namespace DataAccess.Domain.Models;

public class DiscountItem
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public string? InDealing { get; set; }
    public bool? IsPerc { get; set; }
    public decimal? SaleDiscount { get; set; }
    public decimal? PurchaseDiscount { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public bool? IsActive { get; set; }
    public int? ItemCounts { get; set; }
    public string? Ship { get; set; }
    public bool? UseQty { get; set; }
    public bool? UsePriceLevel { get; set; }
    public string? PriceLevels { get; set; }
    public bool? UsePermissions { get; set; }
    public string? Permissions { get; set; }
    public Guid Rowguid { get; set; }
}
