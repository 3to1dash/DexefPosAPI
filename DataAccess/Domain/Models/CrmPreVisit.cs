namespace DataAccess.Domain.Models;

public class CrmPreVisit
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? VisitDate { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public string? FollowWith { get; set; }
    public bool? Done { get; set; }
    public Guid Rowguid { get; set; }
}
