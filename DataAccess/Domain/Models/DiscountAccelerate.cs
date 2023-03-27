namespace DataAccess.Domain.Models;

public class DiscountAccelerate
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public decimal? Perc { get; set; }
    public decimal? Minday { get; set; }
    public decimal? Maxday { get; set; }
    public bool? Active { get; set; }
    public decimal? Accountid { get; set; }
    public Guid Rowguid { get; set; }
}