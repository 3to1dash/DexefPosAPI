namespace DataAccess.Domain.Models;

public partial class TaxValidation
{
    public TaxValidation()
    {
        TaxValidationResults = new HashSet<TaxValidationResult>();
    }

    public int Id { get; set; }
    public DateTime? UploadedDt { get; set; }
    public decimal? TaskId { get; set; }
    public string? Uuid { get; set; }
    public string? Status { get; set; }

    public virtual ICollection<TaxValidationResult> TaxValidationResults { get; set; }
}
