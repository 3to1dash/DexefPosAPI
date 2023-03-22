namespace DataAccess.Domain.Models;

public class FixedAssetsCategory
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? AreaId { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
}
