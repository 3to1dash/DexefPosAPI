namespace DataAccess.Domain.Models;

public partial class RepManEntry
{
    public int Id { get; set; }
    public int? RepId { get; set; }
    public int? WorkId { get; set; }
    public decimal? Perc { get; set; }
    public Guid Rowguid { get; set; }
}
