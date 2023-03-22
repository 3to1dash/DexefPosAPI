namespace DataAccess.Domain.Models;

public class PurchaseQuoteItem
{
    public decimal Id { get; set; }
    public decimal? KindId { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? OrderId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Price { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Total { get; set; }
    public Guid Rowguid { get; set; }
}
