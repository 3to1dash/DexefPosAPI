namespace DataAccess.Domain.Models;

public partial class WorkInstallment
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public string? Ship { get; set; }
    public decimal? Monthly { get; set; }
    public decimal? Value { get; set; }
    public decimal? Profit { get; set; }
    public decimal? PercValue { get; set; }
    public decimal? Counts { get; set; }
    public decimal? Total { get; set; }
    public decimal? StartMonth { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public decimal? Regnum { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? Accountid { get; set; }
    public int? PayType { get; set; }
    public string? Store { get; set; }
    public decimal? OperatIndex { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? CostId { get; set; }
    public bool? Done { get; set; }
    public Guid Rowguid { get; set; }
}
