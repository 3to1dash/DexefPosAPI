namespace DataAccess.Domain.Models;

public class HrTaxSettingsEntry
{
    public int Id { get; set; }
    public int? TaxId { get; set; }
    public int? Num { get; set; }
    public decimal? FromValue { get; set; }
    public decimal? ToValue { get; set; }
    public decimal? Value { get; set; }
    public decimal? Perc { get; set; }
    public decimal? DiscountPerc { get; set; }
    public Guid Rowguid { get; set; }
}
