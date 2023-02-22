namespace DataAccess.Domain.Models;

public partial class ItemAdjustment
{
    public decimal Id { get; set; }
    public decimal? Accountid { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? Itemid { get; set; }
    public decimal? Nowqty { get; set; }
    public decimal? Newqty { get; set; }
    public decimal? Diffqty { get; set; }
    public decimal? Nowval { get; set; }
    public decimal? Newval { get; set; }
    public decimal? Diffval { get; set; }
    public string? Unite { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Regnum { get; set; }
    public string? Stock { get; set; }
    public decimal? Total { get; set; }
    public decimal? UniteCost { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Length { get; set; }
    public DateTime? Exprdt { get; set; }
    public string? Serial { get; set; }
    public decimal? Itemcost { get; set; }
    public string? Rowcost { get; set; }
    public Guid Rowguid { get; set; }
}
