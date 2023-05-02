namespace DataAccess.Domain.Models;

public class Dailyga
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public decimal? Tankid { get; set; }
    public string? Detail { get; set; }
    public decimal? Price { get; set; }
    public decimal? Come { get; set; }
    public decimal? Go { get; set; }
    public decimal? Balance { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}