namespace DataAccess.Domain.Models;

public class DailyQuotum
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Kindid { get; set; }
    public string? Unite { get; set; }
    public decimal? Value { get; set; }
    public decimal? Regnum { get; set; }
    public Guid Rowguid { get; set; }
}