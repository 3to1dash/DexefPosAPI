namespace DataAccess.Domain.Models;

public partial class FixedAssetRentMethod
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PeriodType { get; set; }
    public int? RentPeriod { get; set; }
    public int? BranchId { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
}
