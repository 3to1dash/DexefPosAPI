namespace DataAccess.Domain.Models;

public class InvoicePrefixList
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public bool? AutoNumber { get; set; }
    public int? StartFrom { get; set; }
    public bool? StartEveryDay { get; set; }
    public bool? UseCpu { get; set; }
    public string? Dealing { get; set; }
    public int? VisibleIndex { get; set; }
}