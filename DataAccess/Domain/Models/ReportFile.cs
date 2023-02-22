namespace DataAccess.Domain.Models;

public partial class ReportFile
{
    public decimal Id { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public byte[]? Files { get; set; }
    public Guid Rowguid { get; set; }
}
