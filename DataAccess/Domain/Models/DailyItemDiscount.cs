namespace DataAccess.Domain.Models;

public class DailyItemDiscount
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public string? Dealing { get; set; }
    public int? DiscountId { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public decimal? Price { get; set; }
    public decimal? Qty { get; set; }
    public bool? Isperc { get; set; }
    public decimal? Perc { get; set; }
    public decimal? InValue { get; set; }
    public decimal? OutValue { get; set; }
    public int? CustId { get; set; }
    public string? Ship { get; set; }
    public decimal? TaskId { get; set; }
    public int? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
