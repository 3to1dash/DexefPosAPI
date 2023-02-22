namespace DataAccess.Domain.Models;

public partial class TaxValidationResultError
{
    public int Id { get; set; }
    public int? ValidtionResultId { get; set; }
    public string? PropertyName { get; set; }
    public string? PropertyPath { get; set; }
    public string? ErrorCode { get; set; }
    public string? Error { get; set; }
    public string? ErrorAr { get; set; }

    public virtual TaxValidationResult? ValidtionResult { get; set; }
}
