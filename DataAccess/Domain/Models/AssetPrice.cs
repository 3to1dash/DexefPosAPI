namespace DataAccess.Domain.Models;

public partial class AssetPrice
{
    public decimal Id { get; set; }
    public decimal? AssetId { get; set; }
    public decimal? Period { get; set; }
    public decimal? Price { get; set; }
    public Guid Rowguid { get; set; }
}
