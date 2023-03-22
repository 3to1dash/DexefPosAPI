namespace DataAccess.Domain.Models;

public class SaleTotal
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Total { get; set; }
    public decimal? Net { get; set; }
    public bool? Recieved { get; set; }
    public bool? Isdeleted { get; set; }
    public string? Dafter { get; set; }
    public decimal? Num { get; set; }
    public decimal? StoreId { get; set; }
    public decimal? Workid { get; set; }
    public decimal? WorkPerc { get; set; }
    public decimal? WorkValue { get; set; }
    public DateTime? DueDt { get; set; }
    public decimal? DueVal { get; set; }
    public decimal? DisDue { get; set; }
    public decimal? DisItem { get; set; }
    public decimal? DisBill { get; set; }
    public decimal? DatVal { get; set; }
    public decimal? DateValue { get; set; }
    public decimal? TaxVal { get; set; }
    public decimal? TaxValue { get; set; }
    public decimal? Extra { get; set; }
    public decimal? Currencyid { get; set; }
    public decimal? Rate { get; set; }
    public decimal? CurrencyValue { get; set; }
    public string? TheUser { get; set; }
    public Guid Rowguid { get; set; }
}
