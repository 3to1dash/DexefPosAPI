namespace DataAccess.Domain.Models;

public class KindBoune
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public int? SlicesCount { get; set; }
    public int? ItemsCount { get; set; }
}
