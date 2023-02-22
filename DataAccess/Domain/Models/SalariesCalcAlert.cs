namespace DataAccess.Domain.Models;

public partial class SalariesCalcAlert
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
