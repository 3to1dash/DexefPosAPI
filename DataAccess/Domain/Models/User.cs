using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain.Models;

public class User
{
    public string Name { get; set; } = null!;
    public string? Type { get; set; }
    public int? PrivilegeId { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Passward { get; set; }
    public string? FullName { get; set; }
    public string? Mobile1 { get; set; }
    public string? Mobile2 { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? WrittenBy { get; set; }
    public string? Permission { get; set; }
    public int? NotificationId { get; set; }
    public bool? Active { get; set; }
    public bool? MustClose { get; set; }
    public int? CloseStorage { get; set; }
    public bool? CurrentState { get; set; }
    public DateTime? LastOpenTime { get; set; }
    public string? Sn { get; set; }
    public bool? IsnewPass { get; set; }
    public string? UpdatedBy { get; set; }
    public int? Status { get; set; }
    public string? Manager { get; set; }
    public int? DepartmentId { get; set; }
    public int? ShiftId { get; set; }
    public bool? ShowMyReportOnly { get; set; }
    public Guid Rowguid { get; set; }
    public int? JobId { get; set; }
    public int? ReportTemplateId { get; set; }

    [NotMapped]
    public virtual UserDepartment? Department { get; set; }
    [NotMapped]
    public virtual UserJob? Job { get; set; }
    [NotMapped]
    public virtual UserNotification? Notification { get; set; }
    [NotMapped]
    public virtual UsersPrivilege? Privilege { get; set; }
    [NotMapped]
    public virtual List<UsersPrivilegesEntry> UsersPrivilegesEntries { get; set; }
    [NotMapped]
    public virtual HrWorkTime? Shift { get; set; }
    [NotMapped]
    public virtual List<UserAnyDeskSetting> UserAnyDeskSettings { get; set; }
    [NotMapped]
    public virtual List<UsersLog> UsersLogs { get; set; }
    [NotMapped]
    public virtual List<UsersResource> UsersResources { get; set; }
}
