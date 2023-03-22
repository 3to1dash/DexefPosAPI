namespace DataAccess.Domain.Models;

public class SupportType
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? Type { get; set; }
    public Guid Rowguid { get; set; }
}
