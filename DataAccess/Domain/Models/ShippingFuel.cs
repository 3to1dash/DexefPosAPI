namespace DataAccess.Domain.Models;

public class ShippingFuel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public Guid Rowguid { get; set; }
}
