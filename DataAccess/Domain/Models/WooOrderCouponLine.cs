namespace DataAccess.Domain.Models;

public partial class WooOrderCouponLine
{
    public WooOrderCouponLine()
    {
        WooOrderCouponLineMeta = new HashSet<WooOrderCouponLineMetum>();
    }

    public decimal Id { get; set; }
    public string Code { get; set; } = null!;
    public decimal? Discount { get; set; }
    public decimal? DiscountTax { get; set; }
    public decimal? WooOrderid { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
    public virtual ICollection<WooOrderCouponLineMetum> WooOrderCouponLineMeta { get; set; }
}
