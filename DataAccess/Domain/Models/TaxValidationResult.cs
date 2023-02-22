﻿namespace DataAccess.Domain.Models;

public partial class TaxValidationResult
{
    public TaxValidationResult()
    {
        TaxValidationResultErrors = new HashSet<TaxValidationResultError>();
    }

    public int Id { get; set; }
    public int? TaxValidtionId { get; set; }
    public int? StepId { get; set; }
    public string? StepName { get; set; }
    public string? Status { get; set; }
    public string? ErrorCode { get; set; }
    public string? Error { get; set; }
    public string? ErrorAr { get; set; }
    public string? PropertyName { get; set; }
    public string? PropertyPath { get; set; }

    public virtual TaxValidation? TaxValidtion { get; set; }
    public virtual ICollection<TaxValidationResultError> TaxValidationResultErrors { get; set; }
}
