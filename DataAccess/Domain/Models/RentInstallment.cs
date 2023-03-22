namespace DataAccess.Domain.Models;

public class RentInstallment
{
    public int Id { get; set; }
    public int? AssetId { get; set; }
    public int? RentId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
