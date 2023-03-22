namespace DataAccess.Domain.Models;

public class NoteQuick
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Note { get; set; }
    public string? Xcolor { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
