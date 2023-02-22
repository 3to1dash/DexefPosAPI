namespace DataAccess.Domain.Models;

public partial class DiscountTradePermission
{
    public int Id { get; set; }
    public int? DiscountId { get; set; }
    public string? Permission { get; set; }
    public Guid Rowguid { get; set; }
}
