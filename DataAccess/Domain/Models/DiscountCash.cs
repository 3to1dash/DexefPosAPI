namespace DataAccess.Domain.Models;

public partial class DiscountCash
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public string? Name { get; set; }
    public bool? IsPerc { get; set; }
    public int? ApplyCondition { get; set; }
    public bool? DiscountInBill { get; set; }
    public decimal? Days { get; set; }
    public decimal? Discount { get; set; }
    public int? DiscountWithin { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public string? Ship { get; set; }
    public bool? IsNetPrice { get; set; }
    public int? PeriodIndex { get; set; }
    public decimal? Discount2 { get; set; }
    public int? DiscountWithin2 { get; set; }
    public Guid Rowguid { get; set; }
}
