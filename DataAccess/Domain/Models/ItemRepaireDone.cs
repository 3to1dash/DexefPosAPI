namespace DataAccess.Domain.Models;

public class ItemRepaireDone
{
    public decimal Id { get; set; }
    public decimal? Itemid { get; set; }
    public decimal? Itemcost { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Total { get; set; }
    public string? Note { get; set; }
    public bool? Repaired { get; set; }
    public bool? Refused { get; set; }
    public bool? Warranty { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Perc { get; set; }
    public decimal? Percval { get; set; }
    public decimal? Cost { get; set; }
    public bool? HasItems { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}