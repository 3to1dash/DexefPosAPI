namespace DataAccess.Domain.Models;

public partial class SmscustGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public bool? Ismanuel { get; set; }
    public int? TypeIndex { get; set; }
    public int? Value { get; set; }
    public int? GroupId { get; set; }
}
