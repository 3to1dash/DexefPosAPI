namespace DataAccess.Domain.Models;

public class TeleSalesRevision
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Groupid { get; set; }
    public decimal? Custid { get; set; }
    public DateTime? Dt { get; set; }
    public string? Time { get; set; }
    public bool? Call { get; set; }
    public bool? Talab { get; set; }
    public bool? Remain { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
