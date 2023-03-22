namespace DataAccess.Domain.Models;

public class Smspatrol
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? IsAll { get; set; }
    public int? Type { get; set; }
    public int? Period { get; set; }
    public int? GroupId { get; set; }
    public int? TemplateId { get; set; }
}
