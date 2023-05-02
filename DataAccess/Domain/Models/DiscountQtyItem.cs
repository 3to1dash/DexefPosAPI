namespace DataAccess.Domain.Models;

public class DiscountQtyItem
{
    public long Id { get; set; }
    public int? DiscountId { get; set; }
    public int? KindId { get; set; }
    public int? BranchId { get; set; }
    public string? Unite { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? QtyOut { get; set; }
    public decimal? TotalOutQty { get; set; }
    public decimal? UniteQty { get; set; }
    public Guid Rowguid { get; set; }

    public virtual DiscountQty? Discount { get; set; }
}