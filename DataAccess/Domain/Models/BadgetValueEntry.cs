namespace DataAccess.Domain.Models;

public class BadgetValueEntry
{
    public int Id { get; set; }
    public int? BadgetValueId { get; set; }
    public string? Caption { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? ExpectedValue { get; set; }
}