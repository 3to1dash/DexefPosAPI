namespace DataAccess.Domain.Models;

public class DailyChequeOut
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public int Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? ChequeId { get; set; }
    public string? Dealing { get; set; }
    public string? Status { get; set; }
    public int? BankId { get; set; }
    public int? CustId { get; set; }
    public string? Owner { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? ProcessId { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
    public string? TargetOwner { get; set; }
}