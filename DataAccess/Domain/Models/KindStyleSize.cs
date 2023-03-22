namespace DataAccess.Domain.Models;

public class KindStyleSize
{
    public int Id { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public string? SizeCode { get; set; }
    public int? SizeId { get; set; }
}
