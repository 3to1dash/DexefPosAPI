namespace DataAccess.Domain.Models;

public class ChequeOutDone
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public int? CostId { get; set; }
    public int? BankId { get; set; }
    public string? Ctype { get; set; }
    public int? CustId { get; set; }
    public int? CustIndex { get; set; }
    public int? AccountId { get; set; }
    public int? PayIndex { get; set; }
    public int? ChequeId { get; set; }
    public int? RegNum { get; set; }
    public decimal? Total { get; set; }
    public int? ItemCount { get; set; }
    public string? Note { get; set; }
    public decimal? ProcessId { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public bool? Attached { get; set; }
    public int? PeriodId { get; set; }
    public Guid Rowguid { get; set; }
}
