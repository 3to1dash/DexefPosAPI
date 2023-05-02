namespace DataAccess.Domain.Models;

public class Motalaba
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Custid { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public decimal? Perccheck { get; set; }
    public decimal? Percval { get; set; }
    public decimal? Khasm { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dtrequire { get; set; }
    public decimal? Total { get; set; }
    public bool? Optall { get; set; }
    public bool? Optrecieved { get; set; }
    public bool? Optexist { get; set; }
    public decimal? Days { get; set; }
    public Guid Rowguid { get; set; }
}