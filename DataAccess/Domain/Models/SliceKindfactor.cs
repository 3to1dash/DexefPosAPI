namespace DataAccess.Domain.Models;

public partial class SliceKindfactor
{
    public decimal Id { get; set; }
    public decimal? SliceId { get; set; }
    public decimal? Kindindex { get; set; }
    public decimal? Value { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public Guid Rowguid { get; set; }
}
