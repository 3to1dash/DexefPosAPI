namespace DataAccess.Domain.Models;

public class TripExcelSetting
{
    public int Id { get; set; }
    public int? Gds { get; set; }
    public string? Tiket { get; set; }
    public string? Emd { get; set; }
    public string? Void { get; set; }
    public string? Refund { get; set; }
    public string? International { get; set; }
    public string? Domestic { get; set; }
    public string? InTrip { get; set; }
    public string? OutTrip { get; set; }
    public string? InOutTrip { get; set; }
    public string? Chd { get; set; }
    public Guid Rowguid { get; set; }
}