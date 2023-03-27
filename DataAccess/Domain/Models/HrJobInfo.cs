namespace DataAccess.Domain.Models;

public class HrJobInfo
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public int? BranchId { get; set; }
    public int? DivisionId { get; set; }
    public int? DepartmentId { get; set; }
    public int? JobTitleId { get; set; }
    public int? DirectManager { get; set; }
    public string? Note { get; set; }
    public DateTime? Dt { get; set; }
    public string? Writtenby { get; set; }
}