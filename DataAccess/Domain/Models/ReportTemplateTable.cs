namespace DataAccess.Domain.Models;

public class ReportTemplateTable
{
    public string TableName { get; set; } = null!;
    public string? Dealing { get; set; }
    public int? VisibleOrder { get; set; }
}
