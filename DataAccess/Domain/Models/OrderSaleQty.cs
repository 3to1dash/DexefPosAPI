namespace DataAccess.Domain.Models;

public class OrderSaleQty
{
    public decimal Id { get; set; }
    public decimal? Orderindex { get; set; }
    public decimal? Kindid { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public string? Note { get; set; }
    public decimal? Invalue { get; set; }
    public decimal? Outvalue { get; set; }
    public Guid Rowguid { get; set; }
}
