namespace DataAccess.Domain.Models;

public class WorkEvaluationRate
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Value { get; set; }
    public decimal? Renum { get; set; }
    public Guid Rowguid { get; set; }
}
