namespace DataAccess.Domain.Models;

public partial class Smstemplate
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public string? Message { get; set; }
}
