namespace DataAccess.Domain.Models;

public class UserPermission
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public string Permission { get; set; } = null!;
    public string? ArName { get; set; }
    public bool? Isuser { get; set; }
    public bool? Adds { get; set; }
    public bool? Edits { get; set; }
    public bool? Deletes { get; set; }
    public bool? Searchs { get; set; }
    public bool? Prints { get; set; }
    public int? Orders { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public bool? Shown { get; set; }
    public byte? ImageIndex { get; set; }
    public string? Dtname { get; set; }
    public Guid Rowguid { get; set; }
    public string? EditorType { get; set; }

    public virtual List<Menu> Menus { get; set; }
    public virtual List<Report> Reports { get; set; }
    public virtual List<Role> Roles { get; set; }
    public virtual List<UsersPrivilegesEntry> UsersPrivilegesEntries { get; set; }
}
