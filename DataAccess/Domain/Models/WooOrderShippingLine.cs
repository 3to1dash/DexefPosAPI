namespace DataAccess.Domain.Models;

public class WooOrderShippingLine
{
    public decimal Id { get; set; }
    public string MethodTitle { get; set; } = null!;
    public string MethodId { get; set; } = null!;
    public string InstanceId { get; set; } = null!;
    public decimal? Total { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? WooOrderid { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
    public virtual List<WooOrderMetum> WooOrderMeta { get; set; }
    public virtual List<WooTaxItem> WooTaxItems { get; set; }
}
