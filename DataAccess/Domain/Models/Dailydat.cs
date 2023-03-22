namespace DataAccess.Domain.Models;

public class Dailydat
{
    public decimal? Fromid { get; set; }
    public decimal? Toid { get; set; }
    public string? Dealing { get; set; }
    public decimal? Dafter { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public DateTime? Date { get; set; }
    public decimal? Value { get; set; }
    public decimal? Perc { get; set; }
    public string? Note { get; set; }
    public string? ReDeal { get; set; }
    public bool? Active { get; set; }
    public decimal? Idunique { get; set; }
    public decimal? Custid { get; set; }
    public bool? Isdeleted { get; set; }
    public Guid Rowguid { get; set; }
}
