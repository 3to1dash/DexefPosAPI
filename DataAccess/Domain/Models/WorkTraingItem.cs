namespace DataAccess.Domain.Models;

public class WorkTraingItem
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public decimal? Days { get; set; }
    public bool? Incompany { get; set; }
    public bool? Companycost { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Address { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}