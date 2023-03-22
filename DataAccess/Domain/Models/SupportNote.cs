namespace DataAccess.Domain.Models;

public class SupportNote
{
    public decimal Id { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
