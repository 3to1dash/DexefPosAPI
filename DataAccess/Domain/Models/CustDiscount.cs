namespace DataAccess.Domain.Models;

public class CustDiscount
{
    public decimal Id { get; set; }
    public int? CustId { get; set; }
    public int? DiscountId { get; set; }
    public decimal? Discount { get; set; }
    public bool? CanEdit { get; set; }
    public Guid Rowguid { get; set; }
}
