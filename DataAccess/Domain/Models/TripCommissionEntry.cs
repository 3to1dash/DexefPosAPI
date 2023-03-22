namespace DataAccess.Domain.Models;

public class TripCommissionEntry
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? TripCommissionId { get; set; }
    public int? CalcMethod { get; set; }
    public string? TripType { get; set; }
    public string? Destination { get; set; }
    public int? Segments { get; set; }
    public decimal? Perc { get; set; }
    public decimal? Amount { get; set; }
    public string? IsaddCom { get; set; }
    public bool? IsChd { get; set; }
    public Guid Rowguid { get; set; }
    public int? PercType { get; set; }
    public bool? IsSale { get; set; }

    public virtual TripCommission? TripCommission { get; set; }
}
