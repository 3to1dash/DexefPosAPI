namespace DataAccess.Domain.Models;

public class Mostvisited
{
    public decimal Id { get; set; }
    public string? WrittenBy { get; set; }
    public string? Text { get; set; }
    public string? Name { get; set; }
    public decimal? Count { get; set; }
    public Guid Rowguid { get; set; }
}