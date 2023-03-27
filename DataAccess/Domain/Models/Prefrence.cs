namespace DataAccess.Domain.Models;

public class Prefrence
{
    public decimal Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Deal { get; set; }
    public bool? State { get; set; }
    public decimal? Value { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public Guid Rowguid { get; set; }

    public virtual List<PrefrenceEntry> PrefrenceEntries { get; set; }
}