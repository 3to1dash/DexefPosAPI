namespace DataAccess.Domain.Models;

public class DiscountQty
{
    public int Id { get; set; }
    public long? Num { get; set; }
    public string? Name { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public int? Counts { get; set; }
    public long? ItemCounts { get; set; }
    public bool? IsPerc { get; set; }
    public bool? Active { get; set; }
    public bool? IsperSlice { get; set; }
    public Guid Rowguid { get; set; }

    public virtual List<DiscountQtyItem> DiscountQtyItems { get; set; }
    public virtual List<DiscountQtySlice> DiscountQtySlices { get; set; }
}