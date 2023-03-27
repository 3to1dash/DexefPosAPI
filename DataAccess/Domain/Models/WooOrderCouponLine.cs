namespace DataAccess.Domain.Models;

public class WooOrderCouponLine
{
    public decimal Id { get; set; }
    public string Code { get; set; } = null!;
    public decimal? Discount { get; set; }
    public decimal? DiscountTax { get; set; }
    public decimal? WooOrderid { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
    public virtual List<WooOrderCouponLineMetum> WooOrderCouponLineMeta { get; set; }
}