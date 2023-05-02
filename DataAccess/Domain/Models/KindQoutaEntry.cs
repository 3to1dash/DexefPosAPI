namespace DataAccess.Domain.Models;

public class KindQoutaEntry
{
    public int Id { get; set; }
    public bool? Active { get; set; }
    public int? BranchId { get; set; }
    public int? QoutaId { get; set; }
    public bool? Isall { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public int? KindId { get; set; }
    public string? Unite { get; set; }
    public decimal? Qty { get; set; }
    public decimal? UniteQty { get; set; }
    public decimal? TotalQty { get; set; }
    public Guid Rowguid { get; set; }
}