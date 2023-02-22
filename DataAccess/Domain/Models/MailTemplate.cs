namespace DataAccess.Domain.Models;

public partial class MailTemplate
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Template { get; set; }
    public Guid Rowguid { get; set; }
}
