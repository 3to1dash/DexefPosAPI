namespace DataAccess.Domain.Models;

public partial class TaxesPay
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public int? AccountId { get; set; }
    public int? PayId { get; set; }
    public int? PayIndex { get; set; }
    public decimal? Value { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? Writtenby { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? Note { get; set; }
    public bool? IsCredit { get; set; }
    public string? ReNum { get; set; }
    public int? PeriodId { get; set; }
    public Guid Rowguid { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
}
