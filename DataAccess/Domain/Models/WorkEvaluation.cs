namespace DataAccess.Domain.Models;

public class WorkEvaluation
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? TotalValue { get; set; }
    public Guid Rowguid { get; set; }
}