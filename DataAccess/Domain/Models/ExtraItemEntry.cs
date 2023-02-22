namespace DataAccess.Domain.Models;

public partial class ExtraItemEntry
{
    public decimal Id { get; set; }
    public int? KindId { get; set; }
    public int? DiscountId { get; set; }
    public Guid Rowguid { get; set; }
}
