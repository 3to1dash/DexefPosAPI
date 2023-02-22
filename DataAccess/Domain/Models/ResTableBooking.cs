namespace DataAccess.Domain.Models;

public partial class ResTableBooking
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? CustId { get; set; }
    public int? BranchId { get; set; }
    public int? PeopleCount { get; set; }
    public int? TableCount { get; set; }
    public string? Memo { get; set; }
    public DateTime? DtStartBooking { get; set; }
    public DateTime? DtEndBooking { get; set; }
    public string? TimeStartBooking { get; set; }
    public string? TimeEndBooking { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public int? Label { get; set; }
}
