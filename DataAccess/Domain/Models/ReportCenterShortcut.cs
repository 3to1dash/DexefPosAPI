namespace DataAccess.Domain.Models;

public partial class ReportCenterShortcut
{
    public int Id { get; set; }
    public int? ReportId { get; set; }
    public int? ParentId { get; set; }
    public int? VisibleOrder { get; set; }
}
