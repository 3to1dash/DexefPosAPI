namespace DataAccess.Domain.Models;

public partial class DailyTax
{
    public int Id { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? HijriDt { get; set; }
    public int? TaxId { get; set; }
    public int? CustId { get; set; }
    public int? AccountId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public int? KindId { get; set; }
    public string? Dealing { get; set; }
    public decimal? TaskId { get; set; }
    public int? Regnum { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public bool? StoreDelete { get; set; }
    public bool? IsUpdated { get; set; }
    public string? Ship { get; set; }
    public int? BranchId { get; set; }
    public int? Cpu { get; set; }
    public int? PeriodId { get; set; }
    public string? ParentShip { get; set; }
    public int? CostId { get; set; }
    public decimal? NetTotal { get; set; }
    public Guid Rowguid { get; set; }
    public string? TranCode { get; set; }
}
