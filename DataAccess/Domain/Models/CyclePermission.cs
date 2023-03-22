namespace DataAccess.Domain.Models;

public class CyclePermission
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? Permission { get; set; }
    public Guid Rowguid { get; set; }
}
