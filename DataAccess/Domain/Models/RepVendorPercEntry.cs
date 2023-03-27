namespace DataAccess.Domain.Models;

public class RepVendorPercEntry
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? KindId { get; set; }
    public decimal? SaleCount { get; set; }
    public decimal? SaleQty { get; set; }
    public decimal? SaleAmount { get; set; }
    public decimal? SaleAvgPrice { get; set; }
    public decimal? ReSaleCount { get; set; }
    public decimal? ReSaleQty { get; set; }
    public decimal? ReSaleAmount { get; set; }
    public decimal? ReSaleAvgPrice { get; set; }
    public decimal? NetCount { get; set; }
    public decimal? NetQty { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? NetAvgPrice { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? SliceName { get; set; }
    public string? SliceLevel { get; set; }
    public decimal? PercAmount { get; set; }
    public decimal? Perc { get; set; }
    public string? CalcType { get; set; }
    public int? SlideAccountId { get; set; }
    public int? AccountId { get; set; }
    public int? RepVendorSliceId { get; set; }
    public int? VendorId { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public int? RowId { get; set; }
    public Guid Rowguid { get; set; }
}