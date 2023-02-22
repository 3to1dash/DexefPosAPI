namespace DataAccess.Domain.Models;

public partial class TempConvert
{
    public long? KindId { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? InCost { get; set; }
    public decimal? OutCost { get; set; }
    public decimal? DiffCost { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public int IsDebit { get; set; }
    public Guid Rowguid { get; set; }
}
