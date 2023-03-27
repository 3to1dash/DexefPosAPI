namespace DataAccess.Domain.Models;

public class BatchNumberDeactivate
{
    public int Id { get; set; }
    public int? ItemId { get; set; }
    public int? BatchId { get; set; }
    public string Reason { get; set; } = null!;
    public string? Explanation { get; set; }
    public string? Dealing { get; set; }
    public int? RsdUserId { get; set; }
}