namespace DataAccess.Domain.Models;

public class MaintenanceDelivery
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public int? CustId { get; set; }
    public int? MaintenanceId { get; set; }
    public string? DeviceModel { get; set; }
    public string? DeviceSerial { get; set; }
    public int? PaymentIndex { get; set; }
    public int? CapitalId { get; set; }
    public decimal? Value { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalPay { get; set; }
    public decimal? TotalRemin { get; set; }
    public int? ExtraId { get; set; }
    public decimal? ExtraValue { get; set; }
    public string? Note { get; set; }
    public bool? Isguarantee { get; set; }
    public bool? Attached { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
}