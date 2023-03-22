namespace DataAccess.Domain.Models;

public class SadadServiceEntry
{
    public decimal Id { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? BranchId { get; set; }
    public string? Item { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? Discount { get; set; }
    public decimal? DiscountPerc { get; set; }
    public string? Note { get; set; }
    public int? RowId { get; set; }
    public Guid Rowguid { get; set; }
}
