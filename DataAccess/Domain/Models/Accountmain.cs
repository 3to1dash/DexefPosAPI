namespace DataAccess.Domain.Models;

/// <summary>
/// كل التعاملات اللي بتحصل على الحسابات
/// </summary>
public class Accountmain
{
    public long Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public int? AccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Value { get; set; }
    public decimal? ActualRate { get; set; }
    public decimal? Rate { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public string? Dealing { get; set; }
    public string? Ship { get; set; }
    public string? ParentShip { get; set; }
    public string? Note { get; set; }
    public decimal? BranchId { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? CostId { get; set; }
    public decimal? Cpu { get; set; }
    public decimal? PeriodId { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public bool? Updated { get; set; }
    public long? ItemCostRow { get; set; }
    public decimal? Deleteddebit { get; set; }
    public decimal? DeletedCredit { get; set; }
    public decimal? DeletedLocalDebit { get; set; }
    public decimal? DeletedLocalCredit { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public Guid Rowguid { get; set; }
}
