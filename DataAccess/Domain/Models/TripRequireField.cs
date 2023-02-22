namespace DataAccess.Domain.Models;

public partial class TripRequireField
{
    public int Id { get; set; }
    public string? Ticket { get; set; }
    public bool? Amount { get; set; }
    public bool? Fees { get; set; }
    public bool? Pnr { get; set; }
    public bool? PaxName { get; set; }
    public bool? PaxAge { get; set; }
    public bool? PaxPhone { get; set; }
    public bool? SaleCommission { get; set; }
    public bool? FlightNumber { get; set; }
    public bool? AirLine { get; set; }
    public bool? DepPort { get; set; }
    public bool? ArrPort { get; set; }
    public bool? Segment { get; set; }
    public bool? Direction { get; set; }
    public bool? Intrnational { get; set; }
    public bool? Class { get; set; }
    public bool? Routes { get; set; }
    public Guid Rowguid { get; set; }
    public bool? PurchaseCommission { get; set; }
}
