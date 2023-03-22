namespace DataAccess.Domain.Models;

public class KindAssembly
{
    public int Id { get; set; }
    public int? MainId { get; set; }
    public int? KindId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? Discount { get; set; }
    public Guid Rowguid { get; set; }
}
