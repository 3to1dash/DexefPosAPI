namespace DataAccess.Domain.Models;

public partial class DailyDate
{
    public decimal Id { get; set; }
    public decimal? DateId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public string? Note { get; set; }
    public string? Telesales { get; set; }
    public string? Salesman { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Renum { get; set; }
    public Guid Rowguid { get; set; }
}
