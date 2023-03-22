namespace DataAccess.Domain.Models;

public class RepSliceEntry
{
    public int Id { get; set; }
    public int? SliceId { get; set; }
    public string? CalcType { get; set; }
    public decimal? FromAmount { get; set; }
    public decimal? ToAmount { get; set; }
    public string? IsPerc { get; set; }
    public decimal? Perc { get; set; }
    public Guid Rowguid { get; set; }
}
