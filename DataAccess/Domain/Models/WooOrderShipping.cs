namespace DataAccess.Domain.Models;

public class WooOrderShipping
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Company { get; set; } = null!;
    public string Address1 { get; set; } = null!;
    public string Address2 { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Postcode { get; set; } = null!;
    public string Country { get; set; } = null!;

    public virtual List<WooOrder> WooOrders { get; set; }
}