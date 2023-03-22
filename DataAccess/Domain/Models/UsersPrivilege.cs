namespace DataAccess.Domain.Models;

public class UsersPrivilege
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? IsAdmin { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public DateTime? Dt { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }

    public virtual List<User> Users { get; set; }
    public virtual List<UsersPrivilegesEntry> UsersPrivilegesEntries { get; set; }
}
