namespace DataAccess.Domain.Models;

public class RepPerc
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public string? Ship { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public int? AccountId { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public string? WrittenBy { get; set; }
    public int? Cpu { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public int? Counts { get; set; }
    public decimal? Total { get; set; }
    public Guid Rowguid { get; set; }
}
