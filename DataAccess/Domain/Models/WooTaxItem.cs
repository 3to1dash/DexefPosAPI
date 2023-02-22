namespace DataAccess.Domain.Models;

public partial class WooTaxItem
{
    public decimal Id { get; set; }
    public decimal? Total { get; set; }
    public decimal? Subtotal { get; set; }
    public decimal? WooOrderFeeLineid { get; set; }
    public decimal? WooOrderLineItemid { get; set; }
    public decimal? WooOrderShippingLineid { get; set; }

    public virtual WooOrderFeeLine? WooOrderFeeLine { get; set; }
    public virtual WooOrderLineItem? WooOrderLineItem { get; set; }
    public virtual WooOrderShippingLine? WooOrderShippingLine { get; set; }
}
