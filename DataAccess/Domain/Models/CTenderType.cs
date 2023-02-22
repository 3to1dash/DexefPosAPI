namespace DataAccess.Domain.Models;

public partial class CTenderType
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? NameEn { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
