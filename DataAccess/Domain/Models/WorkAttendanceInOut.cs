namespace DataAccess.Domain.Models;

public class WorkAttendanceInOut
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Number { get; set; }
    public string? TimeOffType { get; set; }
    public int? EmplId { get; set; }
    public DateTime? LogTime { get; set; }
    public string? Writtenby { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}
