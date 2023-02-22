namespace DataAccess.Domain.Models;

public partial class CalendarEventGenerator
{
    public long Id { get; set; }
    public string? Subject { get; set; }
    public string? SubjectArName { get; set; }
    public string? Description { get; set; }
    public string? DescriptionArName { get; set; }
    public string? Location { get; set; }
    public string? LocationArName { get; set; }
    public decimal? FromTick { get; set; }
    public decimal? ToTick { get; set; }
    public bool? AllDay { get; set; }
    public int? LabelId { get; set; }
    public int? EventType { get; set; }
    public int? StatusId { get; set; }
    public Guid Rowguid { get; set; }
}
