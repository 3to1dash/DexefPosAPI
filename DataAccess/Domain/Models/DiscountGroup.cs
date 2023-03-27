namespace DataAccess.Domain.Models;

public class DiscountGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? Discount { get; set; }
    public bool? Active { get; set; }
    public bool? CanEdit { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}