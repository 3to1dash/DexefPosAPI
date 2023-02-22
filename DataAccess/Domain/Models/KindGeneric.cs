namespace DataAccess.Domain.Models;

public partial class KindGeneric
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Detail { get; set; }
    public decimal? KindId { get; set; }
    public Guid Rowguid { get; set; }
}
