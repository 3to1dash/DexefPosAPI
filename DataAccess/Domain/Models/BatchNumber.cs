namespace DataAccess.Domain.Models;

public class BatchNumber
{
    public decimal Id { get; set; }
    public decimal? KindId { get; set; }
    public decimal? ItemId { get; set; }
    public string? Operate { get; set; }
    public DateTime? ExprDt { get; set; }
    public decimal? InQty { get; set; }
    public decimal? OutQty { get; set; }
    public decimal? Qty { get; set; }
    public DateTime? ManufacturingDt { get; set; }
    public int? NotificationDays { get; set; }
    public string? Barcode { get; set; }
    public string? Sn { get; set; }
    public string? Detail { get; set; }
    public string? Note { get; set; }
    public decimal? Temp { get; set; }
    public Guid Rowguid { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public bool? IsActive { get; set; }
}
