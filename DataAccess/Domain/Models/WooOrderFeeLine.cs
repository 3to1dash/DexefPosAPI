namespace DataAccess.Domain.Models;

public partial class WooOrderFeeLine
{
    public WooOrderFeeLine()
    {
        WooOrderMeta = new HashSet<WooOrderMetum>();
        WooTaxItems = new HashSet<WooTaxItem>();
    }

    public decimal Id { get; set; }
    public string Name { get; set; } = null!;
    public string TaxClass { get; set; } = null!;
    public string TaxStatus { get; set; } = null!;
    public decimal? Total { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? WooOrderid { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
    public virtual ICollection<WooOrderMetum> WooOrderMeta { get; set; }
    public virtual ICollection<WooTaxItem> WooTaxItems { get; set; }
}
