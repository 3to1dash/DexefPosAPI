namespace DataAccess.Domain.Models;

public partial class UsersPrivilege
{
    public UsersPrivilege()
    {
        Users = new HashSet<User>();
        UsersPrivilegesEntries = new HashSet<UsersPrivilegesEntry>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? IsAdmin { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public DateTime? Dt { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }

    public virtual ICollection<User> Users { get; set; }
    public virtual ICollection<UsersPrivilegesEntry> UsersPrivilegesEntries { get; set; }
}
