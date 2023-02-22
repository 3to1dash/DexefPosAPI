namespace DataAccess.Domain.Models;

public partial class EmplSalariesSliceEntry
{
    public int Id { get; set; }
    public int? SliceId { get; set; }
    public decimal? FromAmount { get; set; }
    public decimal? ToAmount { get; set; }
    public decimal? Amount { get; set; }
}
