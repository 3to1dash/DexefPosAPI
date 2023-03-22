namespace DataAccess.Domain.Models;

public class DailyCashPaid
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public decimal? RegNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public decimal? Total { get; set; }
    public decimal? Remain { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Discount { get; set; }
    public bool? Done { get; set; }
    public string? Note { get; set; }
    public decimal? WorkId { get; set; }
    public DateTime? DueDt { get; set; }
    public DateTime? PaidDt { get; set; }
    public decimal? PaidNum { get; set; }
    public string? PaidUser { get; set; }
    public decimal? ReferId { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
