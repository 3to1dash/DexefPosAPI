namespace DataAccess.Domain.Models;

public class ExtraItem
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? IsPerc { get; set; }
    public decimal? Value { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public bool? IsRun { get; set; }
    public int? ItemCount { get; set; }
    public string? InDealing { get; set; }
    public Guid Rowguid { get; set; }
}
