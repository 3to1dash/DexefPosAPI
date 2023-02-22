namespace DataAccess.Domain.Models;

public partial class SupportPriority
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
    public bool? IsDefault { get; set; }
    public Guid Rowguid { get; set; }
}
