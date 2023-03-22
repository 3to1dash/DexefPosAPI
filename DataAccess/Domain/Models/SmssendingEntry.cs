namespace DataAccess.Domain.Models;

public class SmssendingEntry
{
    public int Id { get; set; }
    public int? SendingId { get; set; }
    public int? CustId { get; set; }
    public int? GroupId { get; set; }
    public int? PatrolId { get; set; }
    public string? Phone { get; set; }
    public string? Message { get; set; }
    public bool? Issuccessful { get; set; }
    public decimal? TaskId { get; set; }
}
