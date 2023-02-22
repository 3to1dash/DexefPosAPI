namespace DataAccess.Domain.Models;

public partial class InsurancesPercent
{
    public int Id { get; set; }
    public int? InsurancesId { get; set; }
    public int? Ratio { get; set; }
}
