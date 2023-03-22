namespace DataAccess.Domain.Models;

public class FixedAssetCategory
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? AreaId { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public bool? Attached { get; set; }
    public Guid Rowguid { get; set; }
}
