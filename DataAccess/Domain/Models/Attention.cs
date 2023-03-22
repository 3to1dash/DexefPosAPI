namespace DataAccess.Domain.Models;

public class Attention
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Subject { get; set; }
    public string? Detail { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
