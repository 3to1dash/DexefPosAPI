namespace DataAccess.Domain.Models;

public class CustConvert
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Fromcust { get; set; }
    public decimal? Tocust { get; set; }
    public string? Main { get; set; }
    public string? Note { get; set; }
    public decimal? Value { get; set; }
    public decimal? Renum { get; set; }
    public decimal? Regnum { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public string? Fromname { get; set; }
    public string? Toname { get; set; }
    public decimal? Branchid { get; set; }
    public Guid Rowguid { get; set; }
}
