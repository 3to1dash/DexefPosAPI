namespace DataAccess.Domain.Models;

public class RFloor
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public int? Tables { get; set; }
    public int? FromNum { get; set; }
    public int? ToNum { get; set; }
    public Guid Rowguid { get; set; }
}