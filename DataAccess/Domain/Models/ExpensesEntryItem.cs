namespace DataAccess.Domain.Models;

public partial class ExpensesEntryItem
{
    public int Id { get; set; }
    public int? SpentId { get; set; }
    public string? Code { get; set; }
    public string? KindId { get; set; }
    public int? ShipId { get; set; }
    public int? EstimateId { get; set; }
    public decimal? Value { get; set; }
    public decimal? TaskId { get; set; }
    public Guid? Rowguid { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
    public DateTime? LstUpdate { get; set; }
}
