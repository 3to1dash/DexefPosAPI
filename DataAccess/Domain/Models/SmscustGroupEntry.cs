namespace DataAccess.Domain.Models;

public class SmscustGroupEntry
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public bool? Issetting { get; set; }
    public int? GroupId { get; set; }
    public int? CustId { get; set; }
}