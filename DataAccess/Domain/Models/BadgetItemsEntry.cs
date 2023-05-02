namespace DataAccess.Domain.Models;

public class BadgetItemsEntry
{
    public int Id { get; set; }
    public int? BadgetItemId { get; set; }
    public string? Code { get; set; }
    public int? AccountId { get; set; }
}