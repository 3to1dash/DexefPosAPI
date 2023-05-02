namespace DataAccess.Domain.Models;

public class DailyworkHi
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public string? Dealing { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Balance { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Regnum { get; set; }
    public string? Kind { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? TaskId { get; set; }
    public bool? Paid { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}