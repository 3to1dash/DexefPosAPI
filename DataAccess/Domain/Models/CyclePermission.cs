namespace DataAccess.Domain.Models;

public partial class CyclePermission
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? Permission { get; set; }
    public Guid Rowguid { get; set; }
}
