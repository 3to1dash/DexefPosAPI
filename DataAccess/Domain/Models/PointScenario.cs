namespace DataAccess.Domain.Models;

public class PointScenario
{
    public decimal Id { get; set; }
    public bool? IsItem { get; set; }
    public decimal? KindId { get; set; }
    public string? Name { get; set; }
    public decimal? FromValue { get; set; }
    public decimal? ToValue { get; set; }
    public string? Unite { get; set; }
    public decimal? Point { get; set; }
    public bool? Active { get; set; }
    public int? ItemCount { get; set; }
    public int? MyIndex { get; set; }
    public Guid Rowguid { get; set; }
}
