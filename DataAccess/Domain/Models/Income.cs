namespace DataAccess.Domain.Models;

public partial class Income
{
    public decimal Id { get; set; }
    public string? Dealing { get; set; }
    public decimal? Num { get; set; }
    public string? Note { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? StorageId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public decimal? Regnum { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Total { get; set; }
    public decimal? Rate { get; set; }
    public string? Currency { get; set; }
    public string? Ship { get; set; }
    public string? Oname { get; set; }
    public string? Ofield { get; set; }
    public string? Ophone { get; set; }
    public string? Oadress { get; set; }
    public decimal? CashType { get; set; }
    public decimal? Bankid { get; set; }
    public decimal? BranchId { get; set; }
    public string? Dafter { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? CostId { get; set; }
    public bool? Attached { get; set; }
    public Guid Rowguid { get; set; }
}
