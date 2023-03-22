namespace DataAccess.Domain.Models;

public class TaxValidation
{
    public int Id { get; set; }
    public DateTime? UploadedDt { get; set; }
    public decimal? TaskId { get; set; }
    public string? Uuid { get; set; }
    public string? Status { get; set; }

    public virtual List<TaxValidationResult> TaxValidationResults { get; set; }
}
