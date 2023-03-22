namespace DataAccess.Domain.Models;

public class SalaryCalcLog
{
    public decimal Id { get; set; }
    public int? WorkId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
