namespace DataAccess.Domain.Models;

public class InsurancesItemsEntry
{
    public int Id { get; set; }
    public int? InsurancesItemId { get; set; }
    public int? InsuranceCompanyId { get; set; }
    public string? Code { get; set; }
    public int? KindId { get; set; }
    public int? PercentId { get; set; }
    public int? PercentValue { get; set; }
}