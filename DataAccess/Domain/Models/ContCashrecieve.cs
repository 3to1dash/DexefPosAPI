namespace DataAccess.Domain.Models;

public class ContCashrecieve
{
    public DateTime? Dt { get; set; }
    public string? Dafter { get; set; }
    public decimal? Billnum { get; set; }
    public decimal? Fromnum { get; set; }
    public string? Fromaccount { get; set; }
    public decimal? Tonum { get; set; }
    public string? Toaccount { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Cust { get; set; }
    public decimal? Custnum { get; set; }
    public string? Item { get; set; }
    public string? Dealing { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
