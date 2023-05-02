namespace DataAccess.Domain.Models;

public class RestoreTransaction
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
}