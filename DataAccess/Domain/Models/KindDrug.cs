namespace DataAccess.Domain.Models;

public class KindDrug
{
    public int Id { get; set; }
    public int? KindId { get; set; }
    public int? StorageConditionId { get; set; }
    public int? ShiftLife { get; set; }
    public string? Strength { get; set; }
    public string? StrengthUnit { get; set; }
    public string? DistributionArea { get; set; }
    public string? RegisterNumber { get; set; }
    public string? RegisterYear { get; set; }
}
