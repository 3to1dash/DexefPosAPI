namespace DataAccess.Domain.Models;

public class Savedoc
{
    public string? Name { get; set; }
    public string? Path { get; set; }
    public string? Type { get; set; }
    public string? Cmpnum { get; set; }
    public Guid Rowguid { get; set; }
}