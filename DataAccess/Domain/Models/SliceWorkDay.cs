namespace DataAccess.Domain.Models;

public class SliceWorkDay
{
    public decimal Id { get; set; }
    public decimal? SliceId { get; set; }
    public bool? Sat { get; set; }
    public bool? Sun { get; set; }
    public bool? Mon { get; set; }
    public bool? Tue { get; set; }
    public bool? Wed { get; set; }
    public bool? Thu { get; set; }
    public bool? Fri { get; set; }
    public Guid Rowguid { get; set; }
}
