namespace DataAccess.Domain.Models;

public class EstimateDaily
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? EstimateId { get; set; }
    public string? Dealing { get; set; }
    public string? EngDealing { get; set; }
    public string? Deal { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}