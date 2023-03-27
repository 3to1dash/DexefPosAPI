namespace DataAccess.Domain.Models;

public class Favoriteform
{
    public string? Name { get; set; }
    public string? Memo { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}