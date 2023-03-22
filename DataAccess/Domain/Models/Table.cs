namespace DataAccess.Domain.Models;

public class Table
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string CustName { get; set; } = null!;
    public DateTime? DtStartBooking { get; set; }
    public DateTime? DtEndBooking { get; set; }
    public string? TimeStartBooking { get; set; }
    public string? TimeEndBooking { get; set; }
    public int? PeopleCount { get; set; }
    public int? TableCount { get; set; }
    public string? Memo { get; set; }
}
