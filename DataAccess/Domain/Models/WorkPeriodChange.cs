namespace DataAccess.Domain.Models;

public class WorkPeriodChange
{
    public decimal Id { get; set; }
    public decimal? PeriodId { get; set; }
    public decimal? GroupId { get; set; }
    public DateTime? LastTime { get; set; }
    public bool? IsChange { get; set; }
    public decimal? ChangeVal { get; set; }
    public Guid Rowguid { get; set; }
}
