namespace DataAccess.Domain.Models;

public partial class WorkMonthly
{
    public decimal Id { get; set; }
    public int? Workid { get; set; }
    public int? MonthId { get; set; }
    public int? WeakId { get; set; }
    public bool? IsPaid { get; set; }
    public bool? Sat { get; set; }
    public bool? Sun { get; set; }
    public bool? Mon { get; set; }
    public bool? Tue { get; set; }
    public bool? Wed { get; set; }
    public bool? Thu { get; set; }
    public bool? Fri { get; set; }
    public Guid Rowguid { get; set; }
}
