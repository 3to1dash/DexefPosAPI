namespace DataAccess.Domain.Models;

public partial class HrAttendPolicyEntry
{
    public int Id { get; set; }
    public int? PolicyId { get; set; }
    public int? WorkShiftId { get; set; }
    public int? BranchId { get; set; }
}
