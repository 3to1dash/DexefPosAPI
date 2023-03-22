namespace DataAccess.Domain.Models;

public class WorkPledgeAdjust
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Prefix { get; set; }
    public int? Num { get; set; }
    public string? BillNum { get; set; }
    public int? PledgeId { get; set; }
    public bool? IsCredit { get; set; }
    public int? Accountid { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public Guid Rowguid { get; set; }
}
