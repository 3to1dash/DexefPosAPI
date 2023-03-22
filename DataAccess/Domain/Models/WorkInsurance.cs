namespace DataAccess.Domain.Models;

public class WorkInsurance
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public decimal? Paid { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public string? Note { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? TypeId { get; set; }
    public decimal? CostId { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
