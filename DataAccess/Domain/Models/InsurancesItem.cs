namespace DataAccess.Domain.Models;

public partial class InsurancesItem
{
    public int Id { get; set; }
    public int? InsurancesId { get; set; }
    public int? PercentId { get; set; }
    public int? ItemsCount { get; set; }
}
