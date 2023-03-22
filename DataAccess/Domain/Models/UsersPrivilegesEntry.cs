namespace DataAccess.Domain.Models;

public class UsersPrivilegesEntry
{
    public int MyId { get; set; }
    public int? PermissionId { get; set; }
    public int? ParentId { get; set; }
    public string? Name { get; set; }
    public string? Permission { get; set; }
    public int? PrivilegeId { get; set; }
    public bool? Isuser { get; set; }
    public bool? Adds { get; set; }
    public bool? Edits { get; set; }
    public bool? Deletes { get; set; }
    public bool? Searchs { get; set; }
    public bool? Prints { get; set; }
    public int? Orders { get; set; }
    public Guid Rowguid { get; set; }
    public string? EditorValue { get; set; }

    public virtual Role? Permission1 { get; set; }
    public virtual UserPermission? PermissionNavigation { get; set; }
    public virtual UsersPrivilege? Privilege { get; set; }
}
