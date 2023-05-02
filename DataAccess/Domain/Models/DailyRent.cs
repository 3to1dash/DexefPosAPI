namespace DataAccess.Domain.Models;

public class DailyRent
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string? Dealing { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Regnum { get; set; }
    public string? Ship { get; set; }
    public Guid Rowguid { get; set; }
}