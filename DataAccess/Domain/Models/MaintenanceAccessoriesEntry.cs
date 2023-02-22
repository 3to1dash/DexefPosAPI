namespace DataAccess.Domain.Models;

public partial class MaintenanceAccessoriesEntry
{
    public int Id { get; set; }
    public int? MaintenanceId { get; set; }
    public int? AccessorieId { get; set; }
}
