namespace DataAccess.Domain.Models;

public partial class WooOrderMetum
{
    public decimal Id { get; set; }
    public decimal? WooOrderFeeLineid { get; set; }
    public decimal? WooOrderLineItemid { get; set; }
    public decimal? WooOrderShippingLineid { get; set; }
    public int? WooOrderTaxLineid { get; set; }
    public decimal? WooOrderid { get; set; }
    public string Key { get; set; } = null!;
    public string DisplayKey { get; set; } = null!;

    public virtual WooOrder? WooOrder { get; set; }
    public virtual WooOrderFeeLine? WooOrderFeeLine { get; set; }
    public virtual WooOrderLineItem? WooOrderLineItem { get; set; }
    public virtual WooOrderShippingLine? WooOrderShippingLine { get; set; }
    public virtual WooOrderTaxLine? WooOrderTaxLine { get; set; }
}
