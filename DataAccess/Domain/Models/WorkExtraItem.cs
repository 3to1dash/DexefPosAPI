namespace DataAccess.Domain.Models;

public class WorkExtraItem
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public bool? Isedit { get; set; }
    public Guid Rowguid { get; set; }
}
