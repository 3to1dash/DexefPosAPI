namespace DataAccess.Domain.Models;

public class UserOption
{
    public decimal MyId { get; set; }
    public decimal? PermissionId { get; set; }
    public decimal? ParentId { get; set; }
    public string? Name { get; set; }
    public string? Permission { get; set; }
    public bool? Isuser { get; set; }
    public bool? Adds { get; set; }
    public bool? Edits { get; set; }
    public bool? Deletes { get; set; }
    public bool? Searchs { get; set; }
    public bool? Prints { get; set; }
    public int? Orders { get; set; }
    public Guid Rowguid { get; set; }

    public virtual UserPermission? PermissionNavigation { get; set; }
}
