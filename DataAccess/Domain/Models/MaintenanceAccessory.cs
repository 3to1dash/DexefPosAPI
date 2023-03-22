namespace DataAccess.Domain.Models;

public class MaintenanceAccessory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LastUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}
