namespace DataAccess.Domain.Models;

public class InvoicePrefix
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public bool? AutoNumber { get; set; }
    public int? StartFrom { get; set; }
    public bool? StartEveryDay { get; set; }
    public bool? UseCpu { get; set; }
    public string? Dealing { get; set; }
    public string? Prefix { get; set; }
    public Guid Rowguid { get; set; }
}