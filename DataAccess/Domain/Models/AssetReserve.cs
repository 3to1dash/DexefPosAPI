namespace DataAccess.Domain.Models;

public class AssetReserve
{
    public decimal Id { get; set; }
    public decimal? Assetid { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? Fromdt { get; set; }
    public DateTime? Todt { get; set; }
    public decimal? Custid { get; set; }
    public decimal? PayType { get; set; }
    public decimal? Accountid { get; set; }
    public decimal? WorkRegNum { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Value { get; set; }
    public decimal? RentId { get; set; }
    public bool? Done { get; set; }
    public Guid Rowguid { get; set; }
}
