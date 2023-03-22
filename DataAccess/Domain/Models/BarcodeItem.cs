namespace DataAccess.Domain.Models;

public class BarcodeItem
{
    public decimal Id { get; set; }
    public string? Code { get; set; }
    public string? Unite { get; set; }
    public string? ExpireBarcode { get; set; }
    public string? VendorCode { get; set; }
    public decimal? Price { get; set; }
    public Guid Rowguid { get; set; }
    public int? ItemId { get; set; }
    public int? Copies { get; set; }
    public string? Operate { get; set; }
}
