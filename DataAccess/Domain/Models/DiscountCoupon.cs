namespace DataAccess.Domain.Models;

public class DiscountCoupon
{
    public decimal Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? Days { get; set; }
    public decimal? Perc { get; set; }
    public DateTime? Dt { get; set; }
    public string? Writtenby { get; set; }
    public bool? Active { get; set; }
    public int? BranchId { get; set; }
    public decimal? MinimumAmount { get; set; }
    public decimal? MaxDiscount { get; set; }
    public Guid Rowguid { get; set; }
}
