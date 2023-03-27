namespace DataAccess.Domain.Models;

public class WorkItinerary
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? Workid { get; set; }
    public string? Type { get; set; }
    public int? Area { get; set; }
    public string? Address { get; set; }
    public string? Note { get; set; }
    public int? Branchid { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public string? Ship { get; set; }
    public int? OperatIndex { get; set; }
    public decimal? Value { get; set; }
    public string? Target { get; set; }
    public int? Days { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public bool? ChkIn { get; set; }
    public bool? ChkOut { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}