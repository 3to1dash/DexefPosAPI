namespace DataAccess.Domain.Models;

public partial class PriceGroup
{
    public DateTime? StDate { get; set; }
    public string? Name { get; set; }
    public string? Detail { get; set; }
    public decimal? Value { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid Rowguid { get; set; }
}
