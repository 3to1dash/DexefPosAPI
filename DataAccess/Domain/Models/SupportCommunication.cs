namespace DataAccess.Domain.Models;

public class SupportCommunication
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public int? ImageIndex { get; set; }
    public string? Description { get; set; }
    public Guid Rowguid { get; set; }
}