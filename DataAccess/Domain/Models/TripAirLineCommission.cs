namespace DataAccess.Domain.Models;

public class TripAirLineCommission
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Name { get; set; }
    public bool? IsPerc { get; set; }
    public decimal? Amount { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }

    public virtual CompanyBranch? Branch { get; set; }
}