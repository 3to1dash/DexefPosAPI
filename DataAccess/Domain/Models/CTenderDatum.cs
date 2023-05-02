namespace DataAccess.Domain.Models;

public class CTenderDatum
{
    public decimal Id { get; set; }
    public decimal? TenderId { get; set; }
    public decimal? ParentId { get; set; }
    public decimal? OrderId { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public string? Detial { get; set; }
    public string? Groups { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public string? Note { get; set; }
    public string? State { get; set; }
    public decimal? ImageIndex { get; set; }
    public bool? IsSubContract { get; set; }
    public decimal? PreTotal { get; set; }
    public decimal? KindId { get; set; }
    public decimal? ItemQty { get; set; }
    public string? ItemUnite { get; set; }
    public decimal? ItemPrice { get; set; }
    public decimal? ItemPreTotal { get; set; }
    public decimal? ProfitPerc { get; set; }
    public decimal? Profit { get; set; }
    public decimal? ItemTotal { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public bool? IsGroup { get; set; }
    public Guid Rowguid { get; set; }
}