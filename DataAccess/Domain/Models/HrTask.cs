namespace DataAccess.Domain.Models;

public class HrTask
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public int? Num { get; set; }
    public int? OwnerId { get; set; }
    public int? AssignedToId { get; set; }
    public int? LinkedToId { get; set; }
    public int? Status { get; set; }
    public int? Priority { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public int? Complete { get; set; }
    public DateTime? DtReminder { get; set; }
    public string? Remindertime { get; set; }
    public string? Subject { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}