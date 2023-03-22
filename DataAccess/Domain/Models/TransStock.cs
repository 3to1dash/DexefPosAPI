namespace DataAccess.Domain.Models;

public class TransStock
{
    public decimal? WorkNum { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Kind { get; set; }
    public string? Type { get; set; }
    public string? Detail { get; set; }
    public string? GroupKind { get; set; }
    public string? GroupLink { get; set; }
    public decimal? StockNum { get; set; }
    public string? StockName { get; set; }
    public string? StockAdress { get; set; }
    public string? Unite { get; set; }
    public decimal? ValUnite { get; set; }
    public decimal? Buy { get; set; }
    public decimal? Sale { get; set; }
    public string? Unite1 { get; set; }
    public decimal? Valsub1 { get; set; }
    public decimal? ValUnite1 { get; set; }
    public decimal? Buy1 { get; set; }
    public decimal? Sale1 { get; set; }
    public string? Unite2 { get; set; }
    public decimal? Valsub2 { get; set; }
    public decimal? ValUnite2 { get; set; }
    public decimal? Buy2 { get; set; }
    public decimal? Sale2 { get; set; }
    public bool? Fill { get; set; }
    public decimal? Minbuy { get; set; }
    public decimal? Minsale { get; set; }
    public decimal? RequireVal { get; set; }
    public decimal? AttentionVal { get; set; }
    public DateTime? ExpDate { get; set; }
    public DateTime? Enterdate { get; set; }
    public Guid Rowguid { get; set; }
}
