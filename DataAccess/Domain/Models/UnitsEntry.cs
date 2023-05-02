namespace DataAccess.Domain.Models;

public class UnitsEntry
{
    public int Id { get; set; }
    public int? UnitId { get; set; }
    public string? Name { get; set; }
    public decimal? Qty { get; set; }
    public string? Currency { get; set; }
    public bool? IsSale { get; set; }
    public bool? IsBuy { get; set; }
    public Guid Rowguid { get; set; }
    public string? Code { get; set; }
}