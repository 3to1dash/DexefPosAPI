namespace DataAccess.Domain.Models;

public class Archive
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Txt { get; set; }
    public string? Rtfformat { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Isarchive { get; set; }
    public Guid Rowguid { get; set; }
}
