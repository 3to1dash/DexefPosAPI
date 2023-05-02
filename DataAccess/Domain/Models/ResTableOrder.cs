namespace DataAccess.Domain.Models;

public class ResTableOrder
{
    public int Id { get; set; }
    public int TableId { get; set; }
    public int OrderId { get; set; }
    public string OrderType { get; set; } = null!;
    public decimal OrderTaskId { get; set; }
}