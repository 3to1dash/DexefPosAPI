namespace DataAccess.Domain.Models;

public class WooOrderTaxLine
{
    public int Id { get; set; }
    public string RateCode { get; set; } = null!;
    public string RateId { get; set; } = null!;
    public string Label { get; set; } = null!;
    public bool? Compound { get; set; }
    public decimal? TaxTotal { get; set; }
    public decimal? ShippingTaxTotal { get; set; }
    public decimal? WooOrderid { get; set; }
    public decimal? RatePercent { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
    public virtual List<WooOrderMetum> WooOrderMeta { get; set; }
}
