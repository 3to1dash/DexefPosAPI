namespace DataAccess.Domain.Models;

public class DailySm
{
    public int Id { get; set; }
    public int? CustId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public int? Smsid { get; set; }
    public string? Number { get; set; }
    public string? Message { get; set; }
    public int? PatrolId { get; set; }
    public int? GroupId { get; set; }
    public string? MessageTemplate { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
}
