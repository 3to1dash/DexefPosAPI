namespace DataAccess.Domain.Models;

public class BranchCycleEntry
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? TableName { get; set; }
    public string? Role { get; set; }
    public Guid Rowguid { get; set; }
}