namespace DataAccess.Domain.Models;

public class ItemSize
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ColorId { get; set; }
    public int? KindId { get; set; }
    public int? StoreId { get; set; }
}