namespace DataAccess.Domain.Models;

public partial class WooOrderCouponLineMetum
{
    public decimal Id { get; set; }
    public decimal? WooOrderCouponLineid { get; set; }
    public string Key { get; set; } = null!;
    public string DisplayKey { get; set; } = null!;

    public virtual WooOrderCouponLine? WooOrderCouponLine { get; set; }
}
