namespace DataAccess.Domain.Models;

public class CostCenterItem
{
    public decimal Id { get; set; }
    public decimal? CostId { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? Qty { get; set; }
    public decimal? TotalCost { get; set; }
    public decimal? Price { get; set; }
    public Guid Rowguid { get; set; }
}