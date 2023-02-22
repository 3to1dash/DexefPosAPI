namespace DataAccess.Domain.Models;

public partial class SalariesCalcPaidSolfa
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Value { get; set; }
    public Guid Rowguid { get; set; }
}
