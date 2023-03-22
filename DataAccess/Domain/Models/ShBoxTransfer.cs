namespace DataAccess.Domain.Models;

public class ShBoxTransfer
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public bool? FromStore { get; set; }
    public bool? FromCust { get; set; }
    public bool? ToStore { get; set; }
    public bool? ToCust { get; set; }
    public string? Ship { get; set; }
    public decimal? Box { get; set; }
    public decimal? BoxRent { get; set; }
    public decimal? BoxSum { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? ToCustid { get; set; }
    public decimal? FromCustid { get; set; }
    public string? FromName { get; set; }
    public string? ToName { get; set; }
    public Guid Rowguid { get; set; }
}
