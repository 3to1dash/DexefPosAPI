namespace DataAccess.Domain.Models;

public partial class AssetRentEntry
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? CustD { get; set; }
    public decimal? AssetId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? Period { get; set; }
    public decimal? Total { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? RentId { get; set; }
    public Guid Rowguid { get; set; }
}
