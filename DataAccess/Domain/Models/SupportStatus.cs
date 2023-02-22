namespace DataAccess.Domain.Models;

public partial class SupportStatus
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public decimal? StatusId { get; set; }
    public bool? Timer { get; set; }
    public string? Description { get; set; }
    public bool? IsDefault { get; set; }
    public string? Status { get; set; }
    public Guid Rowguid { get; set; }
}
