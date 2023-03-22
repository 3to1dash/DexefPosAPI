namespace DataAccess.Domain.Models;

public class DiscountCouponLog
{
    public int CouponId { get; set; }
    public int? ParentId { get; set; }
    public decimal? Perc { get; set; }
    public decimal? MaxAmount { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? TaskId { get; set; }
    public bool? Used { get; set; }
    public string? UsedInvoiceNum { get; set; }
    public decimal? UsedInvoiceTaskId { get; set; }
    public DateTime? UsedDate { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? UsedInvoiceAmount { get; set; }
    public decimal? UsedDiscount { get; set; }
    public Guid Rowguid { get; set; }
}
