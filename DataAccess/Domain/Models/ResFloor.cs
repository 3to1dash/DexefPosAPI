namespace DataAccess.Domain.Models;

public class ResFloor
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public string? Notes { get; set; }
}
