namespace DataAccess.Domain.Models;

public class SalariesRepeatMethod
{
    public int Id { get; set; }
    public string? ItemType { get; set; }
    public string? Name { get; set; }
    public int? FromVal { get; set; }
    public int? ToVal { get; set; }
    public int? SalaryId { get; set; }
    public Guid Rowguid { get; set; }
}