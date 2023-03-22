namespace DataAccess.Domain.Models;

public class WorkPeriod
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public DateTime? FromTime { get; set; }
    public DateTime? ToTime { get; set; }
    public Guid Rowguid { get; set; }
}
