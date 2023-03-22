namespace DataAccess.Domain.Models;

public class Smssending
{
    public int Id { get; set; }
    public int? Smsid { get; set; }
    public int? TemplateId { get; set; }
    public string? MessageTemplate { get; set; }
    public decimal? TaskId { get; set; }
}
