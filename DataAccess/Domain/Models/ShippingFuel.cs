namespace DataAccess.Domain.Models;

public partial class ShippingFuel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public Guid Rowguid { get; set; }
}
