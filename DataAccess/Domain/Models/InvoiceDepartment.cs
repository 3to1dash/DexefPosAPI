namespace DataAccess.Domain.Models;

public class InvoiceDepartment
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Printer { get; set; }
    public int? DesignId { get; set; }
    public int? BranchId { get; set; }
    public int? ItemsCount { get; set; }
}
