namespace DataAccess.Domain.Models;

public class PotVisit
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Iscurrent { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Workid { get; set; }
    public DateTime? VisitDate { get; set; }
    public DateTime? VisitTime { get; set; }
    public string? Reason { get; set; }
    public bool? IsRevsion { get; set; }
    public string? Revisionby { get; set; }
    public bool? IsDone { get; set; }
    public Guid Rowguid { get; set; }
}