namespace DataAccess.Domain.Models;

public class BadgetItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? BadgetId { get; set; }
    public int? ItemType { get; set; }
    public bool? Issale { get; set; }
    public int? ScaleType { get; set; }
    public int? ValueExceedsindex { get; set; }
    public int? ItemsCount { get; set; }
}