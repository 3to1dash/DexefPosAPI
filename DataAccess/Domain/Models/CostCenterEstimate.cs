namespace DataAccess.Domain.Models;

public class CostCenterEstimate
{
    public decimal Id { get; set; }
    public int? CostCenter { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public Guid Rowguid { get; set; }
}
