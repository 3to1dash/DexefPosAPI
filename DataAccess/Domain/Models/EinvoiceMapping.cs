namespace DataAccess.Domain.Models;

public class EinvoiceMapping
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public string? Uuid { get; set; }
    public string? Status { get; set; }
}