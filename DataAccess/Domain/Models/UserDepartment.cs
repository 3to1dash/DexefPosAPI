namespace DataAccess.Domain.Models;

public class UserDepartment
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public string? Manager { get; set; }
    public Guid Rowguid { get; set; }

    public virtual List<User> Users { get; set; }
}