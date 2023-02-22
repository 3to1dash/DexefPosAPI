namespace DataAccess.Domain.Models;

public partial class SupportNote
{
    public decimal Id { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
