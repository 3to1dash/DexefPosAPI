namespace DataAccess.Domain.Models;

public class Maintenance
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public int? CustIndex { get; set; }
    public int? CustId { get; set; }
    public string? Status { get; set; }
    public string? Priority { get; set; }
    public string? DeviceType { get; set; }
    public string? DeviceModel { get; set; }
    public string? DeviceSerial { get; set; }
    public DateTime? DeliveryDt { get; set; }
    public string? TimeDelivery { get; set; }
    public bool? Isguarantee { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public decimal? TaskId { get; set; }
    public int? CompletionRatio { get; set; }
    public bool? Isdelivery { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}