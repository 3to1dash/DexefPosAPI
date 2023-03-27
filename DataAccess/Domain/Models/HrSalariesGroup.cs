namespace DataAccess.Domain.Models;

public class HrSalariesGroup
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public bool? IsAdd { get; set; }
    public Guid Rowguid { get; set; }
}