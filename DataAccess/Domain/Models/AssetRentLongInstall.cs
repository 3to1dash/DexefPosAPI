namespace DataAccess.Domain.Models;

public class AssetRentLongInstall
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public decimal? CustId { get; set; }
    public decimal? AssetId { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public bool? Done { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public Guid Rowguid { get; set; }
}