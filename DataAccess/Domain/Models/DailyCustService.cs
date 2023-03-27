namespace DataAccess.Domain.Models;

public class DailyCustService
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? TicketId { get; set; }
    public decimal? ParentId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? BranchId { get; set; }
    public string? Ship { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
    public bool? IsCust { get; set; }
    public Guid Rowguid { get; set; }
}