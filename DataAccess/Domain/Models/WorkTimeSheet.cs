namespace DataAccess.Domain.Models;

public partial class WorkTimeSheet
{
    public long Id { get; set; }
    public int EmplId { get; set; }
    public string? TimeOffType { get; set; }
    public int? TimeOffId { get; set; }
    public DateTime? Dt { get; set; }
    public bool? CheckIn { get; set; }
    public bool? CheckOut { get; set; }
    public DateTime? CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
    public decimal? AddedHours { get; set; }
    public decimal? DedcutedHours { get; set; }
    public int? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
