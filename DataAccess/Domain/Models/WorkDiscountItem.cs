namespace DataAccess.Domain.Models;

public class WorkDiscountItem
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public bool? Isedit { get; set; }
    public decimal? WageId { get; set; }
    public Guid Rowguid { get; set; }
}
