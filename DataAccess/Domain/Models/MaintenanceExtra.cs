namespace DataAccess.Domain.Models;

public class MaintenanceExtra
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Isedit { get; set; }
    public bool? Isvalue { get; set; }
    public decimal? PriceWithinWarranty { get; set; }
    public decimal? Priceoutsidewarranty { get; set; }
    public Guid Rowguid { get; set; }
}