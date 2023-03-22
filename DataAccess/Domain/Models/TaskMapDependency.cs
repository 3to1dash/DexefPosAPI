namespace DataAccess.Domain.Models;

public class TaskMapDependency
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? DependentId { get; set; }
    public int Type { get; set; }
    public Guid Rowguid { get; set; }
}
