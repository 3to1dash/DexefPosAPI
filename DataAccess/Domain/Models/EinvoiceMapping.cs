namespace DataAccess.Domain.Models;

public partial class EinvoiceMapping
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public string? Uuid { get; set; }
    public string? Status { get; set; }
}
