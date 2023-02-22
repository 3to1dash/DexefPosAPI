namespace DataAccess.Domain.Models;

public partial class TripCommission
{
    public TripCommission()
    {
        TripCommissionEntries = new HashSet<TripCommissionEntry>();
        TripContracts = new HashSet<TripContract>();
    }

    public int Id { get; set; }
    public int? BranchId { get; set; }
    public bool? IsSale { get; set; }
    public string? Name { get; set; }
    public int? CalcMethod { get; set; }
    public decimal? Minmum { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LastUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public int? AccountId { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
    public int? PercType { get; set; }

    public virtual CompanyBranch? Branch { get; set; }
    public virtual ICollection<TripCommissionEntry> TripCommissionEntries { get; set; }
    public virtual ICollection<TripContract> TripContracts { get; set; }
}
