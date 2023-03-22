namespace DataAccess.Domain.Models;

public class EstimateShipEntry
{
    public int Id { get; set; }
    public int? ShipId { get; set; }
    public int? EstimateId { get; set; }
    public string? Code { get; set; }
    public int? KindId { get; set; }
    public decimal? EstimateQty { get; set; }
    public decimal? ShipQty { get; set; }
    public decimal? RemainQty { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? SpentCost { get; set; }
    public decimal? TotalSpent { get; set; }
    public decimal? ItemCost { get; set; }
    public decimal? TotalCost { get; set; }
}
