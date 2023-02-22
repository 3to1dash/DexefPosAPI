namespace DataAccess.Domain.Models;

public partial class WorkPink
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public DateTime? Starttime { get; set; }
    public DateTime? Endtime { get; set; }
    public decimal? Hours { get; set; }
    public Guid Rowguid { get; set; }
}
