namespace DataAccess.Domain.Models;

public partial class DailyworkpercentTemp
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Num { get; set; }
    public string? Dealing { get; set; }
    public decimal? Come { get; set; }
    public decimal? Go { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Perc { get; set; }
    public decimal? Percval { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? BillIndex { get; set; }
    public string? Deal { get; set; }
    public string? EnDealing { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
