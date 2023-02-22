namespace DataAccess.Domain.Models;

public partial class TaskMapResource
{
    public int Id { get; set; }
    public int? IdSort { get; set; }
    public int? ParentId { get; set; }
    public string? Description { get; set; }
    public int? Color { get; set; }
    public byte[]? Image { get; set; }
    public string? CustomField1 { get; set; }
    public Guid Rowguid { get; set; }
}
