namespace DataAccess.Domain.Models;

public partial class Role
{
    public Role()
    {
        UsersPrivilegesEntries = new HashSet<UsersPrivilegesEntry>();
    }

    public int Id { get; set; }
    public string? System { get; set; }
    public int? ParentId { get; set; }
    public int? OrderId { get; set; }
    public string? RoleId { get; set; }
    public byte? ImageIndex { get; set; }
    public Guid Rowguid { get; set; }

    public virtual UserPermission? RoleNavigation { get; set; }
    public virtual ICollection<UsersPrivilegesEntry> UsersPrivilegesEntries { get; set; }
}
