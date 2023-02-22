namespace DataAccess.Domain.Models;

public partial class UserBranch
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? BranchId { get; set; }
    public bool? Deal { get; set; }
    public bool? SearchOnly { get; set; }
    public bool? TransferTo { get; set; }
    public bool? Isdefault { get; set; }
    public Guid Rowguid { get; set; }
}
