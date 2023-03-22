namespace DataAccess.Domain.Models;

public class BillCustDiscount
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public string? Dealing { get; set; }
    public int? DiscountId { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Invalue { get; set; }
    public bool? CanEdit { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}
