namespace DataAccess.Domain.Models;

public class ResTableBookingEntry
{
    public int Id { get; set; }
    public int? BookingId { get; set; }
    public int? TableId { get; set; }
    public string? TableName { get; set; }
    public int? FloorId { get; set; }
    public string? FloorName { get; set; }
    public DateTime? DtStartBooking { get; set; }
    public DateTime? DtEndBooking { get; set; }
    public bool? Isavailable { get; set; }
}