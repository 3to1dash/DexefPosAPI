namespace DataAccess.Domain.Models;

public partial class WooOrderLineItem
{
    public WooOrderLineItem()
    {
        WooOrderMeta = new HashSet<WooOrderMetum>();
        WooTaxItems = new HashSet<WooTaxItem>();
    }

    public decimal Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal? ProductId { get; set; }
    public decimal? VariationId { get; set; }
    public decimal? Quantity { get; set; }
    public string TaxClass { get; set; } = null!;
    public decimal? Subtotal { get; set; }
    public decimal? SubtotalTax { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalTax { get; set; }
    public string Sku { get; set; } = null!;
    public decimal? Price { get; set; }
    public decimal? WooOrderid { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
    public virtual ICollection<WooOrderMetum> WooOrderMeta { get; set; }
    public virtual ICollection<WooTaxItem> WooTaxItems { get; set; }
}
