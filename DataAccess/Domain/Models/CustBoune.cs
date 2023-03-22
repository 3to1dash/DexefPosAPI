namespace DataAccess.Domain.Models;

public class CustBoune
{
    public decimal Id { get; set; }
    public bool? IsRecieve { get; set; }
    public bool? IsDiscount { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? Num { get; set; }
    public string? Main { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Total { get; set; }
    public decimal? Value { get; set; }
    public decimal? Perc { get; set; }
    public string? Note { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? Branchid { get; set; }
    public Guid Rowguid { get; set; }
}
