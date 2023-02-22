namespace DataAccess.Domain.Models;

public partial class FixedAssetDepreciation
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? Dep { get; set; }
    public string? DepName { get; set; }
    public bool? IsFixedRatio { get; set; }
    public decimal? Ratio { get; set; }
    public int? DestroyId { get; set; }
    public int? DestoryDiscountId { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}
