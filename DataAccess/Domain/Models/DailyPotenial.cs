namespace DataAccess.Domain.Models;

public class DailyPotenial
{
    public decimal Id { get; set; }
    public decimal? TicketId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? CustId { get; set; }
    public decimal? StatusId { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? FollowWith { get; set; }
    public string? Ship { get; set; }
    public decimal? TaskId { get; set; }
    public string? Type { get; set; }
    public Guid Rowguid { get; set; }
}