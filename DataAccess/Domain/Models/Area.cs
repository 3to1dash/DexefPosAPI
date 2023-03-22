namespace DataAccess.Domain.Models;

public class Area
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? Name { get; set; }
    public decimal? Num { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public decimal? Amount { get; set; }
    public Guid Rowguid { get; set; }
}
