namespace DataAccess.Domain.Models;

public class TripDateRange
{
    public long Id { get; set; }
    public bool? IsVendor { get; set; }
    public int? CustId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? Days { get; set; }
    public bool? Used { get; set; }
    public Guid Rowguid { get; set; }
}
