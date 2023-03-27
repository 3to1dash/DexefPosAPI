namespace DataAccess.Domain.Models;

public class Unit
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}