namespace DataAccess.Domain.Models;

public class TaxesDat
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public decimal? Perc { get; set; }
    public int? AccountId { get; set; }
    public decimal? DatminInvoice { get; set; }
    public bool? Updated { get; set; }
    public int? CalcMonths { get; set; }
    public DateTime? StartCalcDate { get; set; }
    public Guid Rowguid { get; set; }
    public string? Category { get; set; }
    public string? SubCategory { get; set; }

    public virtual TaxesGroup? CategoryNavigation { get; set; }
    public virtual TaxesSubGroup? SubCategoryNavigation { get; set; }
}