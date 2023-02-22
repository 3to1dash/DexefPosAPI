namespace DataAccess.Domain.Models;

public partial class EmplLoan
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Ship { get; set; }
    public int? EmpId { get; set; }
    public bool? IsOnePeriod { get; set; }
    public int? PayIndex { get; set; }
    public int? AccountId { get; set; }
    public string? LoanAccountId { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? TotalPaidAmount { get; set; }
    public decimal? Remain { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
}
