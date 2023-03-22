namespace DataAccess.Domain.Models;

public class WooOrder
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public string Number { get; set; } = null!;
    public string OrderKey { get; set; } = null!;
    public string CreatedVia { get; set; } = null!;
    public string Version { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string Currency { get; set; } = null!;
    public DateTime? DateCreated { get; set; }
    public DateTime? DateCreatedGmt { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateModifiedGmt { get; set; }
    public decimal? DiscountTotal { get; set; }
    public decimal? DiscountTax { get; set; }
    public decimal? ShippingTotal { get; set; }
    public decimal? ShippingTax { get; set; }
    public decimal? CartTax { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalTax { get; set; }
    public bool? PricesIncludeTax { get; set; }
    public decimal? CustomerId { get; set; }
    public string CustomerIpAddress { get; set; } = null!;
    public string CustomerUserAgent { get; set; } = null!;
    public string CustomerNote { get; set; } = null!;
    public int Billingid { get; set; }
    public int Shippingid { get; set; }
    public string PaymentMethod { get; set; } = null!;
    public string PaymentMethodTitle { get; set; } = null!;
    public string TransactionId { get; set; } = null!;
    public DateTime? DatePaid { get; set; }
    public DateTime? DatePaidGmt { get; set; }
    public DateTime? DateCompleted { get; set; }
    public DateTime? DateCompletedGmt { get; set; }
    public string CartHash { get; set; } = null!;
    public bool? SetPaid { get; set; }

    public virtual WooOrderBilling Billing { get; set; } = null!;
    public virtual WooOrderShipping Shipping { get; set; } = null!;
    public virtual List<WooOrderCouponLine> WooOrderCouponLines { get; set; }
    public virtual List<WooOrderFeeLine> WooOrderFeeLines { get; set; }
    public virtual List<WooOrderLineItem> WooOrderLineItems { get; set; }
    public virtual List<WooOrderMetum> WooOrderMeta { get; set; }
    public virtual List<WooOrderRefundLine> WooOrderRefundLines { get; set; }
    public virtual List<WooOrderShippingLine> WooOrderShippingLines { get; set; }
    public virtual List<WooOrderTaxLine> WooOrderTaxLines { get; set; }
}
