namespace DataAccess.Domain.Models;

public class PotFeature
{
    public decimal Id { get; set; }
    public decimal? Custid { get; set; }
    public int? ItemId { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public string? Kind { get; set; }
    public bool? Ischeck { get; set; }
    public Guid Rowguid { get; set; }
}
