namespace DataAccess.Domain.Models;

public class WorkAbsent
{
    public decimal Id { get; set; }
    public int? Workid { get; set; }
    public string? Dafter { get; set; }
    public decimal? Num { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Value { get; set; }
    public decimal? OperatIndex { get; set; }
    public decimal? TaskId { get; set; }
    public int? BranchId { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public Guid Rowguid { get; set; }
}