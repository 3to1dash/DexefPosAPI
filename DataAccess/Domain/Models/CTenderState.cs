namespace DataAccess.Domain.Models;

public class CTenderState
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? NameEn { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}