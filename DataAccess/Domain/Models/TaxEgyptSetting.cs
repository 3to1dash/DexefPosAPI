namespace DataAccess.Domain.Models;

public partial class TaxEgyptSetting
{
    public int Id { get; set; }
    public int? MaxPeriod { get; set; }
    public decimal? MaxCustValue { get; set; }
}
