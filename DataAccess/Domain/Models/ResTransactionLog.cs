namespace DataAccess.Domain.Models;

public class ResTransactionLog
{
    public decimal Id { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
    public string? Status { get; set; }
    public string? PrevStatus { get; set; }
    public DateTime? Dt { get; set; }
    public int? EmplId { get; set; }
    public string? WrittenBy { get; set; }
}
