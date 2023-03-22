namespace DataAccess.Domain.Models;

public class PotDeleteLog
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public Guid Rowguid { get; set; }
}
