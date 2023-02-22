namespace DataAccess.Domain.Models;

public partial class WorkInsuranceEntry
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public decimal? ReTaskId { get; set; }
    public decimal? Value { get; set; }
    public int? AccountId { get; set; }
    public int? StorageId { get; set; }
    public Guid Rowguid { get; set; }
}
