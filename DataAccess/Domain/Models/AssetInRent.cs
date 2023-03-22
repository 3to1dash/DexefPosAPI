namespace DataAccess.Domain.Models;

public class AssetInRent
{
    public decimal Id { get; set; }
    public decimal? Assetid { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Qty { get; set; }
    public DateTime? Fromdt { get; set; }
    public DateTime? Todt { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
