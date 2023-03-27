namespace DataAccess.Domain.Models;

public class GetExpense
{
    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public string? ReNum { get; set; }
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
}