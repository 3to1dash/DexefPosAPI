namespace DataAccess.Domain.Models;

public partial class ShippingCarUsage
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public int? CarId { get; set; }
    public DateTime? StDt { get; set; }
    public DateTime? EdDate { get; set; }
    public string? MileStart { get; set; }
    public string? MileEnd { get; set; }
    public string? TotalMiles { get; set; }
    public long? CustId { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }
}
