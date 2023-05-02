namespace DataAccess.Domain.Models;

public class PreNameField
{
    public decimal Id { get; set; }
    public string? Type { get; set; }
    public int? TxtIndex { get; set; }
    public string? Text { get; set; }
    public bool? Used { get; set; }
    public string? CtrlType { get; set; }
    public int? TypeId { get; set; }
    public Guid Rowguid { get; set; }
}