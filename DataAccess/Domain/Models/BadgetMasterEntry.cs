namespace DataAccess.Domain.Models;

public class BadgetMasterEntry
{
    public int Id { get; set; }
    public int? MasterId { get; set; }
    public string? Caption { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
}