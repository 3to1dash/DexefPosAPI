namespace DataAccess.Domain.Models;

public class TripAirport
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string? City { get; set; }
    public string? Country { get; set; }
    public bool? IsDomestic { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}