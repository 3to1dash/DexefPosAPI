namespace DataAccess.Domain.Models;

public class Income1
{
    public int Id { get; set; }
    public int? TypeIndex { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public string? ReNum { get; set; }
    public int? PaymentIndex { get; set; }
    public int? CapitalId { get; set; }
    public string? Ship { get; set; }
    public string? Note { get; set; }
    public int? CostId { get; set; }
    public int? RegNum { get; set; }
    public decimal? Value { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public int? Counts { get; set; }
    public int? ClassId { get; set; }
    public int? PeriodId { get; set; }
    public decimal? Tax { get; set; }
    public Guid Rowguid { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
}
