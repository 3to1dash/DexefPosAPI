namespace DataAccess.Domain.Models;

public class SalariesEntry
{
    public decimal? Id { get; set; }
    public int? SalaryId { get; set; }
    public int? SubId { get; set; }
    public bool? IsAdd { get; set; }
    public string? Type { get; set; }
    public string? ServiceType { get; set; }
    public string? ServiceId { get; set; }
    public Guid Rowguid { get; set; }
}
