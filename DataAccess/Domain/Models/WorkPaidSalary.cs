namespace DataAccess.Domain.Models;

public class WorkPaidSalary
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public DateTime? Dt { get; set; }
    public int? CurMonth { get; set; }
    public int? CurYear { get; set; }
    public decimal? RegNum { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? Value { get; set; }
    public decimal? TaskId { get; set; }
    public DateTime? LastDt { get; set; }
    public Guid Rowguid { get; set; }
}