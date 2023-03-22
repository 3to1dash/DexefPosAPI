namespace DataAccess.Domain.Models;

public class OpOrder
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
