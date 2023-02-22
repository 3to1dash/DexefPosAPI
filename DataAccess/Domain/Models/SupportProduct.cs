namespace DataAccess.Domain.Models;

public partial class SupportProduct
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
