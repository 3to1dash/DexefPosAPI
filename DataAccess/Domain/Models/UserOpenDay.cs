namespace DataAccess.Domain.Models;

public class UserOpenDay
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Username { get; set; }
    public int? Number { get; set; }
    public decimal? OpeningBalance { get; set; }
    public decimal? OpenTaskId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public decimal? CloseBalance { get; set; }
    public decimal? Shortage { get; set; }
    public decimal? Extra { get; set; }
    public decimal? CloseTaskId { get; set; }
    public bool? IsClosed { get; set; }
    public DateTime? CloseTime { get; set; }
    public int? BranchId { get; set; }
    public int? PeriodId { get; set; }
    public Guid Rowguid { get; set; }
}