namespace DataAccess.Domain.Models;

public class CustField
{
    public decimal Id { get; set; }
    public decimal? Subid { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}