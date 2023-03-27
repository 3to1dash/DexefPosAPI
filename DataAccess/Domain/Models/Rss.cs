namespace DataAccess.Domain.Models;

public class Rss
{
    public decimal Id { get; set; }
    public string? Object { get; set; }
    public string? Note { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Active { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public Guid Rowguid { get; set; }
}