namespace DataAccess.Domain.Models;

public class TripDemanding
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? PeriodId { get; set; }
    public int? CustId { get; set; }
    public decimal? Amount { get; set; }
    public int? TicketCount { get; set; }
    public int? VoidCount { get; set; }
    public int? EmdCount { get; set; }
    public int? RefundCount { get; set; }
    public decimal? TicketAmount { get; set; }
    public decimal? VoidAmount { get; set; }
    public decimal? EmdAmount { get; set; }
    public decimal? RefundAmount { get; set; }
    public int? AllCount { get; set; }
    public bool? Sent { get; set; }
    public bool? Done { get; set; }
    public Guid Rowguid { get; set; }
}
