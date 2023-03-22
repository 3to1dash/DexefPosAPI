namespace DataAccess.Domain.Models;

public class MaintenanceEntry
{
    public int Id { get; set; }
    public int? MaintenanceId { get; set; }
    public int? DamageId { get; set; }
    public string? Status { get; set; }
    public int? ComplationRatio { get; set; }
    public int? TecId { get; set; }
    public string? Note { get; set; }
}
