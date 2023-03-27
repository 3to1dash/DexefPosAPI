namespace DataAccess.Domain.Models;

public class FixedAssetArea
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public int? ParentId { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}