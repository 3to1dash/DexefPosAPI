namespace DataAccess.Domain.Models;

public class Taxes
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public decimal? Perc { get; set; }
    public int? TaxId { get; set; }
    public bool? UseVat { get; set; }
    public bool? UseDat { get; set; }
    public decimal? Datperc { get; set; }
    public int? Datid { get; set; }
    public decimal? DatminInvoice { get; set; }
    public Guid Rowguid { get; set; }
    public decimal? SaleTax { get; set; }
    public decimal? PurchaseTax { get; set; }
    public bool? Updated { get; set; }
    public string? TaxType { get; set; }
    public bool? PercIsSame { get; set; }
    public string? Category { get; set; }
    public string? SubCategory { get; set; }
    public bool? IsItemCost { get; set; }
    public string? ItemType { get; set; }

    public virtual TaxesGroup? CategoryNavigation { get; set; }
    public virtual TaxesSubGroup? SubCategoryNavigation { get; set; }
    public virtual List<TripTicket> TripTickets { get; set; }
}
