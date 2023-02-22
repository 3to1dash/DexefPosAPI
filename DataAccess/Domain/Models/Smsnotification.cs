namespace DataAccess.Domain.Models;

public partial class Smsnotification
{
    public int Id { get; set; }
    public int? CustId { get; set; }
    public int? PatrolId { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Balance { get; set; }
    public string? Dealing { get; set; }
    public decimal? DealingValue { get; set; }
    public bool? IsRun { get; set; }
}
