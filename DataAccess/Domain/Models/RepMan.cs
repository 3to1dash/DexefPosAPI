namespace DataAccess.Domain.Models;

public class RepMan
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public string? RepType { get; set; }
    public int? AccountId { get; set; }
    public int? SliceId { get; set; }
    public Guid Rowguid { get; set; }
}
