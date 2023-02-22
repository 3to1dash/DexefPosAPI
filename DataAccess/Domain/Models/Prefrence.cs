namespace DataAccess.Domain.Models;

public partial class Prefrence
{
    public Prefrence()
    {
        PrefrenceEntries = new HashSet<PrefrenceEntry>();
    }

    public decimal Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Deal { get; set; }
    public bool? State { get; set; }
    public decimal? Value { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public Guid Rowguid { get; set; }

    public virtual ICollection<PrefrenceEntry> PrefrenceEntries { get; set; }
}
