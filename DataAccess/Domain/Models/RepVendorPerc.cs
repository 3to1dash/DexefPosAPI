namespace DataAccess.Domain.Models;

public class RepVendorPerc
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public string? VendorIds { get; set; }
    public string? Note { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? PercAmount { get; set; }
    public int? ItemCount { get; set; }
    public int? Cpu { get; set; }
    public int? PeriodId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public decimal? VendorAmount { get; set; }
    public Guid Rowguid { get; set; }
}