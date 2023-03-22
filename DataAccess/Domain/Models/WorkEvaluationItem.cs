namespace DataAccess.Domain.Models;

public class WorkEvaluationItem
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
