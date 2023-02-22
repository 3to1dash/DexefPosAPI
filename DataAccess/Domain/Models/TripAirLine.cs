namespace DataAccess.Domain.Models;

public partial class TripAirLine
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string? Name { get; set; }
    public string Num { get; set; } = null!;
    public string? Country { get; set; }
    public string? Mobile1 { get; set; }
    public string? Mobile2 { get; set; }
    public string? Mobile3 { get; set; }
    public string? Adress { get; set; }
    public bool? Active { get; set; }
    public int? CustId { get; set; }
    public Guid Rowguid { get; set; }
}
