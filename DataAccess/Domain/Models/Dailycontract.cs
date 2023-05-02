namespace DataAccess.Domain.Models;

public class Dailycontract
{
    public DateTime? Dt { get; set; }
    public decimal? Billnum { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Dealing { get; set; }
    public string? Item { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public string? Cust { get; set; }
    public decimal? Custnum { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}