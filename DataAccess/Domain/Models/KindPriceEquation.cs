namespace DataAccess.Domain.Models;

public class KindPriceEquation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? UsedPrice { get; set; }
    public string? UsedEquation { get; set; }
    public decimal? Amount { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}