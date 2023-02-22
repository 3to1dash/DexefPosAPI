namespace DataAccess.Domain.Models;

public partial class Technician
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public string? UserName { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
