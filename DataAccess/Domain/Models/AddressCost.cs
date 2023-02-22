namespace DataAccess.Domain.Models;

public partial class AddressCost
{
    public decimal Id { get; set; }
    public decimal? AreaId { get; set; }
    public decimal? Value { get; set; }
    public bool? AllInIt { get; set; }
    public string? Note { get; set; }
    public bool? CanEdit { get; set; }
    public Guid Rowguid { get; set; }
}
