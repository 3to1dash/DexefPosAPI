namespace DataAccess.Domain.Models;

public partial class WorkIncentive
{
    public decimal Id { get; set; }
    public int? Workid { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Dealing { get; set; }
    public decimal? Type { get; set; }
    public int? Branchid { get; set; }
    public int? OperatIndex { get; set; }
    public int? AccountId { get; set; }
    public int? CapitalId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? PayType { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public Guid Rowguid { get; set; }
}
