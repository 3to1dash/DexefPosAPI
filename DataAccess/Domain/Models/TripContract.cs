namespace DataAccess.Domain.Models;

public class TripContract
{
    public int Id { get; set; }
    public bool? Active { get; set; }
    public int? BranchId { get; set; }
    public bool? IsCust { get; set; }
    public int? CustId { get; set; }
    public int? TripGdsid { get; set; }
    public int? TripCommissionId { get; set; }
    public bool? CommissionIncludeTaxes { get; set; }
    public bool? IsDiscount { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public int? TripAirLineCommissionId { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attach { get; set; }

    public virtual CompanyBranch? Branch { get; set; }
    public virtual Cust? Cust { get; set; }
    public virtual TripCommission? TripCommission { get; set; }
    public virtual TripGd? TripGds { get; set; }
}