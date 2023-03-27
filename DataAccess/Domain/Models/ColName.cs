namespace DataAccess.Domain.Models;

public class ColName
{
    public long Id { get; set; }
    public string? TableName { get; set; }
    public string? ColName1 { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public Guid Rowguid { get; set; }
}