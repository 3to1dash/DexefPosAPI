namespace DataAccess.Domain.Models;

public class RKitchen
{
    public int Id { get; set; }
    public int? Floorid { get; set; }
    public int? TableId { get; set; }
    public string? RegNum { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? KindId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Cpu { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
