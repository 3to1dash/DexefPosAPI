namespace DataAccess.Domain.Models;

public partial class WooOrderBilling
{
    public WooOrderBilling()
    {
        WooOrders = new HashSet<WooOrder>();
    }

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
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public virtual ICollection<WooOrder> WooOrders { get; set; }
}
