namespace DataAccess.Domain.Models;

public partial class PartnerGroup
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public Guid Rowguid { get; set; }
}
