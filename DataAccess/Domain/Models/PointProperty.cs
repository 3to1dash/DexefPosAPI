namespace DataAccess.Domain.Models;

public partial class PointProperty
{
    public decimal Id { get; set; }
    public decimal? CreateCost { get; set; }
    public decimal? Expire { get; set; }
    public decimal? ExpireNotUse { get; set; }
    public decimal? ReActivePoint { get; set; }
    public decimal? Value { get; set; }
    public decimal? Counts { get; set; }
    public bool? ConvertPoint { get; set; }
    public decimal? DestroyPoint { get; set; }
    public decimal? Minimum { get; set; }
    public bool? HasSerial { get; set; }
    public Guid Rowguid { get; set; }
}
