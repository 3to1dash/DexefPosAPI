namespace DataAccess.Domain.Models;

public partial class SrvcClass
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
