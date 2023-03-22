namespace DataAccess.Domain.Models;

public class ShortCut
{
    public string? Name { get; set; }
    public bool? Ctrl { get; set; }
    public bool? Shift { get; set; }
    public bool? Alt { get; set; }
    public string? Keys { get; set; }
    public string? Memo { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
