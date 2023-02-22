namespace DataAccess.Domain.Models;

public partial class DiscountQtySlice
{
    public long Id { get; set; }
    public int? DiscountId { get; set; }
    public decimal? FromQty { get; set; }
    public decimal? ToQty { get; set; }
    public decimal? Discount { get; set; }
    public Guid Rowguid { get; set; }

    public virtual DiscountQty? DiscountNavigation { get; set; }
}
