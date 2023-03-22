namespace DataAccess.Domain.Models;

public class MaintenanceTask
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? TecId { get; set; }
    public int? CustIndex { get; set; }
    public int? CustId { get; set; }
    public int? DamgeId { get; set; }
    public int? MaintenanceId { get; set; }
    public DateTime? DtDelivery { get; set; }
    public string? TimeDelivery { get; set; }
    public string? Status { get; set; }
    public string? Priority { get; set; }
    public string? DeviceSerial { get; set; }
    public string? DeviceModel { get; set; }
    public string? Subject { get; set; }
    public string? Description { get; set; }
    public bool? Isreminder { get; set; }
    public DateTime? DtReminder { get; set; }
    public string? TimeReminder { get; set; }
    public int? CompletionRatio { get; set; }
    public decimal? ItemTaskId { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? LstUpdate { get; set; }
}
