namespace DataAccess.Domain.Models;

public partial class SrvcStore
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? Address { get; set; }
    public string? Code { get; set; }
    public Guid Rowguid { get; set; }
}
