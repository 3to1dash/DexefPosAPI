namespace DataAccess.Domain.Models;

public partial class MaintenanceDamage
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? Name { get; set; }
    public string? Note { get; set; }
}
