namespace DataAccess.Domain.Models;

public class Dailyworkpercent
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Num { get; set; }
    public string? Dealing { get; set; }
    public decimal? Sale { get; set; }
    public decimal? Resale { get; set; }
    public decimal? Recieve { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Perc { get; set; }
    public decimal? Percval { get; set; }
    public decimal? Regnum { get; set; }
    public string? Deal { get; set; }
    public string? EnDealing { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? Custid { get; set; }
    public string? Ship { get; set; }
    public decimal? OperatIndex { get; set; }
    public Guid Rowguid { get; set; }
}
