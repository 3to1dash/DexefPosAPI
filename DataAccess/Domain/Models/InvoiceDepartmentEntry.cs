namespace DataAccess.Domain.Models;

public partial class InvoiceDepartmentEntry
{
    public long Id { get; set; }
    public int? ParentId { get; set; }
    public int? KindId { get; set; }
}
