namespace DataAccess.Domain.Models;

public class DailyInsurance
{
    public long Id { get; set; }
    public int? CompanyInsuranceId { get; set; }
    public int? PatientId { get; set; }
    public decimal? Perc { get; set; }
    public decimal? DiscountAmount { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
}