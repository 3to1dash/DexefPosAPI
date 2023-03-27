namespace DataAccess.Domain.Models;

public class Role
{
    public int Id { get; set; }
    public string? System { get; set; }
    public int? ParentId { get; set; }
    public int? OrderId { get; set; }
    public string? RoleId { get; set; }
    public byte? ImageIndex { get; set; }
    public Guid Rowguid { get; set; }

    public virtual UserPermission? RoleNavigation { get; set; }
    public virtual List<UsersPrivilegesEntry> UsersPrivilegesEntries { get; set; }
}